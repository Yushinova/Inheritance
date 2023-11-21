using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Ivanova", "Anna", 28, "C++ developer", 85);
            Student Ivan = new Student("Ivanov", "Ivan", 20, "Ingener", "PV321", 20, 50);
            Student Tanya = new Student("Yushinova", "Tatyana", 38, "Developer", "PV321", 80, 100);
            Graduate Nic = new Graduate("Litvinov", "Nic", 28, "Program Ingener", "PV321", 50, 80, "Information System");
            Group group = new Group();
            group.AddHuman(teacher);
            group.AddHuman(Ivan);
            group.AddHuman(Tanya);
            group.AddHuman(Nic);
            group.ShowGroup();
            string current_directory = Directory.GetCurrentDirectory();
            string filename = "File.txt";
            Console.WriteLine(current_directory);

            if(System.IO.File.Exists(filename))//если файл существует считываем информацию в другую группу
            {
                Group ReadGroup = new Group();
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    string buffer = sr.ReadLine();
                    string[] var = buffer.Split(',');
                    if (var[0] == "Academy.Teacher")
                    {
                        Teacher ReadTeacher = new Teacher(var[1], var[2], Convert.ToInt32(var[3]), var[4], Convert.ToDouble(var[5]));
                        ReadGroup.AddHuman(ReadTeacher);
                    }
                    else if (var[0] == "Academy.Student")
                    {
                        Student ReadStudent = new Student(var[1], var[2], Convert.ToInt32(var[3]), var[4], var[5], Convert.ToDouble(var[6]), Convert.ToDouble(var[7]));
                        ReadGroup.AddHuman(ReadStudent);
                    }
                    else if (var[0] == "Academy.Graduate")
                    {
                        Graduate ReadGrad = new Graduate(var[1], var[2], Convert.ToInt32(var[3]), var[4], var[5], Convert.ToDouble(var[6]), Convert.ToDouble(var[7]), var[8]);
                        ReadGroup.AddHuman(ReadGrad);
                    }
                }
                sr.Close();
                Console.WriteLine("After read:");
                ReadGroup.ShowGroup();
            }
            else//если файл не существует пишем его
            {
                StreamWriter aw = File.AppendText(filename);
                foreach (var item in group.GetGroup())
                {
                    aw.Write(item.GetType() + ",");
                    aw.WriteLine(item.ToWrite());
                }
                aw.Close();
            }
        }
    }
}
