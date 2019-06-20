using System;
namespace LibMediaServiceCommon
{
    /// <summary>
    /// This class is used to log application messages, warnings,
    /// and errors.
    /// </summary>
    public class Logging
    {
        private static volatile Logging instance;
        private static object syncRoot = new Object();

        private string filePath;
        
        
        private Logging() 
        {
            this.filePath = System.IO.Path.Combine(DataDirectory.MajorSilenceMediaServiceLocalAppDataDirectory, "MediaService-Debug.txt");
            System.Diagnostics.Trace.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(this.filePath));
            System.Diagnostics.Trace.AutoFlush = true;
        }

        public static Logging Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Logging();
                        }
                    }
                }

                if (System.IO.Directory.Exists(DataDirectory.MajorSilenceMediaServiceLocalAppDataDirectory) == false)
                {
                    System.IO.Directory.CreateDirectory(DataDirectory.MajorSilenceMediaServiceLocalAppDataDirectory);
                }

                return instance;
            }
        }

        
        public string MajorSilenceLocalAppDataDirectory
        {
            get
            {
                string msDir = null;
                msDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                msDir = System.IO.Path.Combine(msDir, "MajorSilence");
                return msDir;
            }
        }

        
        public void WriteLine(string msg)
        {
            WriteLine(msg, "UNKNOWN");
        }
        public void WriteLine(string msg, string category)
        {
            string output = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + System.Environment.NewLine;
            output += msg + System.Environment.NewLine;
            output += System.Environment.NewLine + System.Environment.NewLine;

            System.Diagnostics.Trace.WriteLine(output, category);
        }

        public void WriteLine(Exception value)
        {
            WriteLine(value, "UNKNOWN");
        }
        public void WriteLine(Exception value, string category)
        {
            WriteLine(value.Message + System.Environment.NewLine + value.StackTrace, category);
        }

    
    }
}

