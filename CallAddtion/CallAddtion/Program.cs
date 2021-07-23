using System;
using System.Diagnostics;
using System.Threading;

namespace CallAddtion
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Random _random = new Random();

                int x = _random.Next();
                int y = _random.Next();
                string[] MyArguments = { x.ToString(), y.ToString() };
                Process process = new Process();
                process.StartInfo.FileName = @"C:\Users\r_abb\source\repos\addition\addition\bin\Debug\netcoreapp3.1\addition.exe";
                process.StartInfo.Arguments = String.Join(" ", MyArguments);

                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
                Thread.Sleep(1000);
            }
        }
    }
}
