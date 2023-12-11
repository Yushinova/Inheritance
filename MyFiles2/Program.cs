using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFiles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string paht = @"C:\Users\User\Desktop\tmp2.txt";
            //string str = "Mother father brothet father";
            //string str = "br br br br\n";
            // using (FileStream file = new FileStream(paht, FileMode.Append))
            // {
            //     byte[]tmp = Encoding.Default.GetBytes(str);
            //     file.Write(tmp, 0, tmp.Length);
            //     Console.WriteLine("oK");
            // }
            //using (FileStream file = new FileStream(paht, FileMode.Open,FileAccess.Read,FileShare.Read))
            //{
            //    //file.Seek(-5, SeekOrigin.End);
            //    byte[] buffer = new byte[(int)file.Length];
            //    file.Read(buffer,0, buffer.Length);
            //    string read = Encoding.Default.GetString(buffer);
            //    Console.WriteLine(read);
            //}
        }
    }
}
