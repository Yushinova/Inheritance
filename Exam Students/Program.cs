using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Exam_Students
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random rn = new Random();
            List<Student> students = new List<Student>
               {
                    new Student{FirstName="Ivan", LastName="Ivanov", BD=new DateTime(2000,1,1)},
                    new Student{FirstName="Petr", LastName="Petrov", BD=new DateTime(2014,3,10)},
                    new Student{FirstName="Sergey", LastName="Surikov", BD=new DateTime(1999,4,23)},
                    new Student{FirstName="Nicole", LastName="Kirova", BD=new DateTime(2010,8,13)},
                    new Student{FirstName="Andre", LastName="Simonov", BD=new DateTime(2003,7,19) }
                };
            Teacher t = new Teacher();
            foreach (var item in students)
            {
                t.event_exam += item.Exam;
            }
            t.Exam("Ex 1");
            foreach (var item in students)
            {
                item.Average = rn.Next(1, 12);
            }
            WriteLine("************");
            foreach (var item in students)
            {
                WriteLine($"{item.LastName} {item.Average}");
            }
            WriteLine("************");
            foreach (var item in students)
            {
                if (item.Average <= 7)
                {
                    t.event_exam -= item.Exam;
                }
            }
            t.Exam("exam 2");

        }
    }

}
