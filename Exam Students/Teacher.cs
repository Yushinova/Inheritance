using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Exam_Students
{
    public delegate void DelegateEx(string str);
    internal class Teacher//источник события
    {

        public event DelegateEx event_exam;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Exam(string exam_work)
        {
            if (event_exam != null)
            {
                event_exam(exam_work);
            }
        }
        public void Exam(List<Student> students, int num)
        {
            for (int i = 0; i < num; i++)
            {
                this.Exam($"Задача: {i + 1}");
                Console.WriteLine($"Итог экзамена {i + 1}");
                Console.WriteLine("***********************");
                foreach (Student item in students)
                {
                    if (item.Average < 7)
                    {
                        event_exam -= item.Exam;

                    }
                    if (item.Average >= 7)
                    {
                        Console.Write("Студент прошел:");
                        Console.WriteLine(item); 
                    }
                    else
                    {
                        Console.Write("Студент отчислен:");
                        Console.WriteLine(item);
                    }
                }
            }
            Console.WriteLine("***********************");
            Console.WriteLine("Поступили: "); 
            foreach (var item in students)
            {
                if(item.Average >= 7) { Console.WriteLine(item); }
            }
        }
    }
}
