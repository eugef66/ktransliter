using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KTransliter.Epub;
using KTransliter.mp3;
using logfig;
namespace KTransliter
{
    

    static class Program
    {
        private static Config m_Settings;
        private static ConfigSection m_MP3Settings;
        private static ConfigSection m_EPUBSettings;

        internal static Config Settings
        {
            get { return Program.m_Settings; }
        }

        internal static ConfigSection MP3Settings
        {
            get { return Program.m_MP3Settings; }
        }

        internal static ConfigSection EPUBSettings
        {
            get { return Program.m_EPUBSettings; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            LoadSettings();

            if (args.Length > 0)
            {
                //Use comand prompt execution
                try
                {


                    string _folder = "";
                    bool _recursive = false;
                    bool _renameFiles = false;
                    string[] _fileTypes = new string[2];
                    int _fileTypeIndex = 0;
                    for (int _i = 0; _i < args.Length; _i++)
                    {
                        switch (args[_i].Replace("/", "").Replace("\\", "").Replace("-", "").ToLower())
                        {
                            case "d": // directory
                                _folder = args[++_i];
                                break;
                            case "s": // include subfolders
                                _recursive = true;
                                break;
                            case "r": // rename files
                                _renameFiles = true;
                                break;
                            case "mp3":
                            case "epub":
                                _fileTypes[_fileTypeIndex++] = args[_i];
                                break;
                            case "?":
                                string _helpMessage = "Syntax: ktanc2e.exe -<switch>\n\n";
                                _helpMessage += "-d <folder>\t- source directory/folder\n";
                                _helpMessage += "-mp3\t\t- process MP3 files\n";
                                _helpMessage += "-epub\t\t- process epub files\n";
                                _helpMessage += "-s\t\t- include subdirectories\n";
                                _helpMessage += "-r\t\t- rename files\n";
                                _helpMessage += "-?\t\t- show this message\n\n";
                                _helpMessage += "Example:\t";
                                _helpMessage += "ktanc2e.exe -d c:\\MyDocs -epub -mp3 -s -r\n";
                                MessageBox.Show(_helpMessage);
                                Environment.Exit(0);
                                break;

                            default:
                                break;
                        }
                    }

                    if (String.IsNullOrEmpty(_folder) && (_fileTypes.Length <= 0))
                    {
                        args = new string[0];
                    }
                    else
                    {
                        
                        foreach (string _fileType in _fileTypes)
                        {
                            FileTypeBase _processor = null;
                            switch (_fileType.ToUpper())
                            {
                                case "EPUB":
                                    _processor = new EPub();
                                    break;
                                case "MP3":
                                    _processor = new MP3();
                                    break;
                                default:
                                    continue;
                            }
                            _processor.ProcessFolder(_folder, _recursive, _renameFiles, Console.Out);
                            MessageBox.Show("Finished Succesufy.");
                            
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("==================================");
                    Console.WriteLine(ex.ToString());
                }

            }

            if (args.Length <= 0)
            {
                // Show GUI
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
        }

        internal static void LoadSettings()
        {
            m_Settings = null;
            m_Settings = new Config("ktanc2e.ksf");
            m_MP3Settings = m_Settings.GetSection("MP3").GetSection("METADATA");
            m_EPUBSettings = m_Settings.GetSection("EPUB").GetSection("METADATA");
        }

    }
}
