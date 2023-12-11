using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MyStream
{
    internal class Program
    {
        //DriveInfo driveInfo;
        //Directory(static не нужно создавать объект) and DirectoryInfo
        //Метки *.txt любые имена расширение txt
        //Fileinfo
        static void Main(string[] args)
        {
            DriveInfo [] dr = DriveInfo.GetDrives();
            foreach (var item in dr)
            {
                Console.WriteLine($"{item.Name} {item.DriveType}");
                if(item.IsReady)
                {
                Console.WriteLine($"{item.VolumeLabel} {item.TotalSize} {item.TotalFreeSpace}");
                Console.WriteLine();
                }
            }
            string name_dir = @"C:\Users\User\Desktop";
            //if(Directory.Exists(name_dir))
            //{
            //    Console.WriteLine("ПОДКАТАЛОГИ");
            //   string[] all_dir = Directory.GetDirectories(name_dir);
            //    foreach (var item in all_dir)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("Files");
            //    string[] all_files = Directory.GetFiles(name_dir);
            //    foreach (var item in all_files)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //find files
            string[] find_dir = Directory.GetDirectories(name_dir, "stand_interf*.");
            foreach (var item in find_dir)
            {
                Console.WriteLine(item);
            }
            string[] files = Directory.GetFiles(name_dir, "*.docx");
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            //создание каталога 
            string paht = @"C:\Users\User\Desktop\New\";
            string sub_paht = @"Student";
            DirectoryInfo info = new DirectoryInfo(paht);
            if(info.Exists)
            {
                info.Create();
            }
            info.CreateSubdirectory(sub_paht);
            Console.WriteLine($"{info.FullName} {info.CreationTime} {info.Root}");
            //info.Delete(true);//без  true не удалит
            //FILES
            FileInfo file = new FileInfo(@"C:\Users\User\Desktop\New\tmp.txt");
            string new_file = @"C:\Users\User\Desktop\tmp.txt";
            if (!file.Exists)
            {
                file.Create();
                Console.WriteLine($"{file.FullName} {file.CreationTime} {file.Length}");
            }
            else
            {
                file.MoveTo(new_file);
            }

        }
    }
}
