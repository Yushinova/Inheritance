//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;
//namespace MyEvents
//{
//    public delegate double MyCalcDelegate(double x, double y);
//    //generic delegate шаблонный
//    public delegate T MyCalcDelegate1<T>(T x, T y);
//    //обобщенные
//    public class MyClass
//    {
//        public double print(double x, double y)
//        {
//            WriteLine("Summ:");
//            return x + y;
//        }
//    }
//    public class MyCalc
//    {
//        public double Add(double x, double y) { return x + y; }
//        public int Add(int x, int y) { return x + y; }//перегрузить для инт
//        public double Sub(double x, double y) { return x - y; }
//        public static double Mul(double x, double y) { return x * y; }
//        public double Div(double x, double y)
//        {
//            if (y != 0) { return x / y; }
//            else
//            {
//                throw new DivideByZeroException();
//            }

//        }
//    }
//    internal class Program
//    {
//        //Delegate - это ссылка на метод
//        static void Main(string[] args)
//        {
//            MyCalc calc = new MyCalc();
//            MyCalcDelegate d1 = new MyCalcDelegate(calc.Add);
//            WriteLine($"{d1(2.5, 8.5)}");//ввод чисел
//            int n;
//            n = Int32.Parse(ReadLine());
//            switch (n)
//            {
//                case 1: d1 = new MyCalcDelegate(calc.Add); break;
//                case 2: d1 = new MyCalcDelegate(calc.Sub); break;
//                case 3: d1 = new MyCalcDelegate(MyCalc.Mul); break;
//                case 4: d1 = new MyCalcDelegate(calc.Div); break;
//                default: throw new InvalidOperationException();

//            }
//            //multicasting это массив делегатов
//            MyCalcDelegate d2 = null;
//            d2 += calc.Add;
//            d2 += calc.Sub;
//            d2 += MyCalc.Mul;
//            d2 += calc.Div;
//            foreach (MyCalcDelegate item in d2.GetInvocationList())
//            {
//                WriteLine(item(2.5, 3.8));
//            }
//            MyCalcDelegate1<int> d3 = calc.Add;//сработает шаблонный делегат
//                                               //обобщенные делегаты
//            MyClass obj = new MyClass();
//            d2 = obj.print;
//            WriteLine(d2(2.5, 3.2));
//        }
 
//    }
//}
