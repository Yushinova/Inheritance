using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonim_and_Lyamda
{
    //delegate int Sum(int num);
    //internal class Program
    //{
    //    //анонимные методы применяют в основном для работы с делегатами
    //    //delegate=delegate(){}
    //    //func(){} - delegate -event delegate
    //    static Sum Sum_my()
    //    {
    //        Random rn = new Random();
    //        int res = 0;
    //        Sum del = delegate (int num)
    //        {
    //            for (int i = 0; i < num; i++)
    //            {
    //                res += rn.Next(20);
    //            }
    //            return res;
    //        };
    //        return del;
    //    }
    //    static void Main(string[] args)
    //    {
    //       Sum del = Sum_my();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine($"Summ {i} = {del(i)}");
    //        }
    //    }
    //}
    //class Program
    //{
    //    delegate string MyDelegate(string str);
    //    static void Main(string[]args)
    //    {
    //        string str1 = " , average part,";
    //        MyDelegate d1 = delegate (string str)
    //        {
    //            str += str1;
    //            str += " end part";
    //            return str;
    //        };
    //        Console.WriteLine(d1("First part "));
    //    }
    //}


    //3
    public delegate double AnonimDelegateDouble(double x, double y);
    public delegate void AnonimDelegateInt(int n);
    public delegate void AnonimDelegateVoid();
    class Dispacher
    {
        public event AnonimDelegateDouble eventDouble;
        public event AnonimDelegateInt eventVoid;
        public double OnEventDouble(double x, double y)
        {
            if (eventDouble != null)
            {
                return eventDouble(x, y);
            }
            throw new NullReferenceException();
        }
        public void OnEventVoid(int n = 0)
        {
            if (eventVoid != null)
            {
                eventVoid(n);
            }
        }
    }
    class Program
    {
        public static void Sum(int a,int b) => Console.WriteLine("Res: " + (a+b));
        static void Main(string[] args)
        {
            Console.WriteLine("\tThe use of events");
            Dispacher dispacher = new Dispacher();
            //dispacher.eventDouble += delegate (double a, double b)
            //{
            //    if (b != 0)
            //    {
            //        return a / b;
            //    }
            //    throw new DivideByZeroException();
            //};
            dispacher.eventDouble += (double a, double b) =>//явная типизация
            {
                 if (b != 0)
                 {
                     return a / b;
                 }
                 throw new DivideByZeroException();
             };
            double n1 = 5.7, n2 = 3.2;
            Console.WriteLine(n1 + " / " + n2 + " = " + dispacher.OnEventDouble(n1, n2));
            Console.WriteLine(" Using a local variable");
            int number = 5;
            dispacher.eventVoid += delegate (int n)//анонимные функции
            {
                Console.WriteLine(number + " + " + n + " = " + (number + n));
            };
            dispacher.eventVoid += n =>//лямбда (неявная типизация если один параметр и он не меняется)
            {
                Console.WriteLine(number + " + " + n + " = " + (number + n));
            };
            dispacher.OnEventVoid();
            dispacher.OnEventVoid(6);
            Console.WriteLine("\tThe use of a delegate");
            AnonimDelegateVoid voidDel =
            new AnonimDelegateVoid(delegate { Console.WriteLine("Ok!"); });

           // voidDel += delegate { Console.WriteLine("Bye!"); };
            voidDel+=()=> { Console.WriteLine("Bye!"); };
            voidDel(); // вызов
            Sum(5, 2);
        }
    }
}
