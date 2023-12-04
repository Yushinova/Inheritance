using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> ZOO = new List<Animal>();
            ZOO.Add(new Lion { Type="Лев африканский", Age=5, Gender="male"});
            ZOO.Add(new Wolf { Type = "Волк степной", Age = 1, Gender = "female" });
            ZOO.Add(new Giraffe { Type = "Жираф африканский", Age = 2, Gender = "male" });
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В НАШ ВИРТУАЛЬНЫЙ ЗООПАРК!");
            Camera camera = new Camera();
            camera.ShowAnimals(ZOO);
        }
    }

}

