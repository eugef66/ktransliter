using System;
using System.Collections.Generic;

using System.Text;
using Ionic.Zip;
using System.IO;
using Ionic.Zlib;
using System.Xml;
using System.NaturalLanguage.Tools;
using System.Windows.Forms;
using logfig;

namespace KTransliter.Epub
{


    public class EPub : FileTypeBase
    {

        

        public EPub() : base() { }





        public override void ProcessFile(string fileName, object logControl)
        {



            // Open epud in Zip utility
            ZipFile _epub = new ZipFile(fileName);
            _epub.TempFileFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //Get collection of *.opf file (should be only one)

            List<ZipEntry> _opfs = _epub.SelectEntries("*.opf", "OEBPS") as List<ZipEntry>;



            if (_opfs.Count > 0)
            {
                // Get first opf file 
                ZipEntry _opf = _opfs[0];

                // Get opf file stream
                CrcCalculatorStream _t = _opf.OpenReader();

                // Create XmlDocument and load it with opf file content
                XmlDocument _xdoc = new XmlDocument();
                XmlNamespaceManager _nsMan = new XmlNamespaceManager(_xdoc.NameTable);
                _xdoc.Load(_t);
                _nsMan.AddNamespace("opf", "http://www.idpf.org/2007/opf");
                _nsMan.AddNamespace("dc", "http://purl.org/dc/elements/1.1/");

                // Get book title node
                XmlNode _metadata = _xdoc.DocumentElement.SelectSingleNode("opf:metadata", _nsMan);
                // Replace children text with translited version
                foreach (XmlNode _metaDataNode in _metadata.ChildNodes)
                {
                    if (Program.EPUBSettings.GetConfigKey(_metaDataNode.LocalName, false).Value.ToUpper() == "TRUE")
                    {
                        _metaDataNode.InnerText = Transliterate(_metaDataNode.InnerText);
                    }
                }

                //Create MemoryStream for modified file
                MemoryStream _opfFile = new MemoryStream();

                //Write modified XmlDocument into MemoryStream
                XmlWriterSettings _xmSet = new XmlWriterSettings();
                _xmSet.Indent = true;
                _xmSet.ConformanceLevel = ConformanceLevel.Auto;
                _xmSet.OmitXmlDeclaration = false;

                XmlWriter _xwrite = XmlWriter.Create(_opfFile, _xmSet);
                _xdoc.Save(_xwrite);
                _opfFile.Flush();
                _opfFile.Position = 0;


                // Update opf file within epub archive
                _epub.UpdateEntry(_opf.FileName, _opfFile);
                // Save changes in epub
                _epub.Save();



                WriteLog(logControl, " - SUCCESS \n");


            }
        }




        public override string FileSearchPatern
        {
            get { return "*.epub"; }
        }
    }
}
