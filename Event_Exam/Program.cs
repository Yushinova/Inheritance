using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Event_Exam
    
{

    //class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public DateTime BD { get; set; }
    //    public override string ToString()
    //    {
    //        return $"{FirstName,15} {LastName,15} {BD.ToShortDateString(),17} ";
    //    }
    //    public void Exam(string exam_work)
    //    {
    //        WriteLine( $" student {LastName} do {exam_work}");
    //    }
    //}
    //class Teacher
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public void Exam(string str)
    //    {
    //        if(event_exam!=null)
    //        {
    //            event_exam(str);
    //        }
    //    }
    //    public event DelegateEx event_exam;
    //}
    //    public delegate void DelegateEx(string str);
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Student> students = new List<Student>
    //           {
    //                new Student{FirstName="Ivan", LastName="Ivanov", BD=new DateTime(2000,1,1)},
    //                new Student{FirstName="Petr", LastName="Petrov", BD=new DateTime(2014,3,10)},
    //                new Student{FirstName="Sergey", LastName="Surikov", BD=new DateTime(1999,4,23)},
    //                new Student{FirstName="Nicole", LastName="Kirova", BD=new DateTime(2010,8,13)},
    //                new Student{FirstName="Andre", LastName="Simonov", BD=new DateTime(2003,7,19) }
    //            };
    //        Teacher t = new Teacher();
    //        foreach (var item in students)
    //        {
    //            t.event_exam += item.Exam;
    //        }
    //        t.Exam("Ex 1");
    //    }
    //}
    class Student
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
            WriteLine($" student {LastName} do {exam_work} ");

        }
       
    }
    class Teacher
    {
        Random rn = new Random();
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Exam(string str)
        {
            foreach (var item in sort_ev.Keys)
            {
                if (sort_ev[item]!=null)
                {
                    sort_ev[item](str);
                }
            }
        }
        public event DelegateEx event_exam
        {
            add
            {
                for (int key; ;)
                {
                    key = rn.Next();
                    if (!sort_ev.ContainsKey(key))
                    {
                        
                        sort_ev.Add(key, value);
                        break;
                    }
                }
            }
            remove
            {
                sort_ev.RemoveAt(sort_ev.IndexOfValue(value));
            }
        }
        SortedList<int, DelegateEx> sort_ev = new SortedList<int, DelegateEx>();
    }
    public delegate void DelegateEx(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
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
