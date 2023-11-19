//#define WRITE
#define READ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string current_directory = Directory.GetCurrentDirectory();
            string filename = "File.txt";
            Console.WriteLine(current_directory);
#if WRITE
            string current_directory = Directory.GetCurrentDirectory();
            string filename = "File.txt";
            Console.WriteLine("Hello files");
            //StreamWriter sw = new StreamWriter(filename);
            //sw.WriteLine("Hello files");
            //sw.Close();
            StreamWriter aw = File.AppendText(filename))
            aw.WriteLine("Append");
            aw.Close();

            string cmd = $"{current_directory}\\{filename}";
            System.Diagnostics.Process.Start("notepad", cmd);
#endif
            try
            {
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    string buffer = sr.ReadLine();
                    Console.WriteLine(buffer);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
