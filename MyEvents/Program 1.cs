using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BD { get; set; }
    //public override string ToString()
    //{
       // return $"{FirstName,15} {LastName,15} {BD.ToShortDateString(),17} ";
    //}
}

class Programm
{
    static string MyFunc(Student st)
    {
        return $"{st.FirstName,15} {st.LastName,15} ";
    }
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
        IEnumerable<string> group = students.Select(MyFunc);//это стандартный делегат
        foreach (var item in group)
        {
            WriteLine(item);
        }
        //Func<TResult> (принимает до 16 параметров)
        //тип значения объявляется при объявлении делегата T
        //используют для класса Enumerable
        //используется в обобщенном методе Select<TSorce, TResult>
        //последовательность элементов которые получаем прри преобразовании
        //Action<T> void используется для стандартных методов, например ForEach


    }
}
