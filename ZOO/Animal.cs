using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZOO
{
    abstract class Animal : IAnimal
    {
        public string Type { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public abstract void Show();//рисунок
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Speak();
        public abstract void Walk();
        public void Info()
        {
           Console.WriteLine("Info: " + Type + " Пол: " +  Gender + " Возраст: " +  Age + " лет");
        }
        public abstract override string ToString();
    }
}
