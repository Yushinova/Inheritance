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
            if(event_exam != null)
            {
                event_exam(exam_work);
            }
            //foreach (var item in sort_ev.Keys)
            //{
            //    if (sort_ev[item] != null)
            //    {
            //        sort_ev[item](str);
            //    }
            //}
        }
        //public event DelegateEx event_exam
        //{
        //    add
        //    {
        //        for (int key; ;)
        //        {
        //            key = rn.Next();
        //            if (!sort_ev.ContainsKey(key))
        //            {

        //                sort_ev.Add(key, value);
        //                break;
        //            }
        //        }
        //    }
        //    remove
        //    {
        //        sort_ev.RemoveAt(sort_ev.IndexOfValue(value));
        //    }
        //}
        //SortedList<int, DelegateEx> sort_ev = new SortedList<int, DelegateEx>();
    }
}
