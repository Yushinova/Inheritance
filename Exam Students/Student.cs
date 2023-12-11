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

        public override string ToString()
        {
            return $"{FirstName,15} {LastName,15} {BD.ToShortDateString(),17} ";

        }
        public void Exam(string exam_work)
        {
            WriteLine($" student {LastName} do {exam_work} ");//обработчик события экзамен
        }
       
    }
}
