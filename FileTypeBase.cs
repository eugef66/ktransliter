using System;
using System.Collections.Generic;
using System.Text;
using System.NaturalLanguage.Tools;
using System.IO;
using System.Windows.Forms;

namespace KTransliter
{
    public abstract class FileTypeBase
    {

        private Transliterator m_c2lTransliter;
        private string m_FileSearchPatern = "";

        public abstract string FileSearchPatern
        {
            get;
        }


        public FileTypeBase()
        {
            TransliteratorSpecification _c2lSpecs = TransliteratorSpecification.FromSpecificationFile("C2L.tms");
            m_c2lTransliter = Transliterator.FromSpecification(_c2lSpecs);
        }



        public virtual void ProcessFolder(string folderName, bool Recursive, bool RenameFiles, object logControl)
        {

            if (!Directory.Exists(folderName))
            {
                WriteLog(logControl, "Source folder \"" + folderName + "\" not found");
                return;
            }


            if (Recursive && Directory.GetDirectories(folderName).Length > 0)
            {
                foreach (string _folder in Directory.GetDirectories(folderName))
                {
                    ProcessFolder(_folder, Recursive, RenameFiles, logControl);
                }

            }

            string[] _files = Directory.GetFiles(folderName, this.FileSearchPatern);
            WriteLog(logControl, folderName + ": " + _files.Length.ToString() + " files\n");



            foreach (string _ofile in _files)
            {
                try
                {

                    string _fileName = "";

                    if (RenameFiles)
                    {
                        _fileName = Path.GetDirectoryName(_ofile) + "\\" + Transliterate(Path.GetFileName(_ofile));
                        File.Move(_ofile, _fileName);
                    }
                    else
                    {
                        _fileName = _ofile;
                    }

                    this.WriteLog(logControl, "\t" + Path.GetFileName(_fileName));

                    ProcessFile(_fileName, logControl);


                }
                catch (Exception ex)
                {
                    WriteLog(logControl, "\t" + Path.GetFileName(_ofile) + " - FAILED\n");
                }
            }

        }


        public abstract void ProcessFile(string fileName, object logControl);


        protected void WriteLog(object logControl, string text)
        {
            if (logControl != null)
            {
                if (logControl.GetType().IsSubclassOf(typeof(TextWriter)))
                {
                    (logControl as TextWriter).Write(text);

                }
                else if (logControl.GetType().IsSubclassOf(typeof(Control)))
                {
                    (logControl as Control).Text += text;
                    (logControl as Control).Refresh();

                }

                
                Application.DoEvents();


            }
        }
        protected string Transliterate(string text)
        {
            return m_c2lTransliter.Transliterate(text);
        }
    }
}
