using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Exam_Students
{
    internal class Student//приемник события
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BD { get; set; }
        public int Average { get; set; }
        public static Random r;
        public void SetAverage()
        {
            r = new Random();
            Average = r.Next(5, 12);
        }
        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} Оценка: {Average} ";

        }
        public void Exam(string exam_work)
        {
            WriteLine($" student {LastName} do {exam_work} ");//обработчик события экзамен
            this.SetAverage();
            System.Threading.Thread.Sleep(150);
        }
       
    }
}
