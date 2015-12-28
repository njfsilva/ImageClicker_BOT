using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace ImageClicker2
{
    static class Program
    {
        //public static StreamWriter logFile;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //LogStart();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain(logFile));
            Application.Run(new frmMain());
        }

        //public static void LogStart()
        //{
        //    // Set log file name to "log_runDate.txt"
        //    string day = DateTime.Today.Day.ToString();
        //    string month = DateTime.Today.Month.ToString();
        //    string year = DateTime.Today.Year.ToString();
        //    string fileName = "log_" + day + month + year + ".txt";

        //    // Create new file or append to end, if already exists
        //    logFile = File.AppendText(fileName);

        //    logFile.WriteLine("====== Program started: {0} ======", DateTime.Now.ToLongTimeString());
        //    logFile.Flush(); // Save buffer to log file.
        //}

        //private static void OnApplicationExit(object sender, EventArgs e)
        //{
        //    logFile.WriteLine("====== Program stopped: {0} ======", DateTime.Now.ToLongTimeString());
        //    logFile.WriteLine("");
        //    logFile.Flush();
        //    logFile.Close();
        //}
    }
}
