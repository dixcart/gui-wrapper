using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Timers;
using System.Net;

namespace Gui_Wrapper
{
    class Program
    {
        

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            String fileName = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                sb.Append(args[i] + " ");
            }
            String arguments = sb.ToString();
            Console.WriteLine(fileName + " " + arguments);
            
            Process prcGui;
            prcGui = new Process();

            prcGui.StartInfo.UseShellExecute = false;
            prcGui.StartInfo.FileName = fileName;
            prcGui.StartInfo.Arguments = arguments;
            //prcGui.StartInfo.CreateNoWindow = true;
            prcGui.StartInfo.RedirectStandardError = true;
            prcGui.StartInfo.RedirectStandardInput = true;
            prcGui.StartInfo.RedirectStandardOutput = true;
            //prcGui.StartInfo.WorkingDirectory = this.strWorkingDir;

            //Set up events
            prcGui.OutputDataReceived += new DataReceivedEventHandler(prcGui_OutputDataReceived);
            prcGui.ErrorDataReceived += new DataReceivedEventHandler(prcGui_ErrorDataReceived);
            prcGui.EnableRaisingEvents = true;
            prcGui.Exited += new System.EventHandler(prcGui_Exited);

            //Finally start the thing
            prcGui.Start();
            prcGui.BeginOutputReadLine();
            prcGui.BeginErrorReadLine();

            prcGui.WaitForExit();

            int intExitCode = prcGui.ExitCode;

            Console.WriteLine("Exit Code: " + intExitCode.ToString());

            Environment.Exit(intExitCode);
        }

        static void prcGui_Exited(object sender, System.EventArgs e)
        {
            Console.WriteLine("App Exited");
        }

        static void prcGui_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }

        static void prcGui_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.Data);
        }
    }
}
