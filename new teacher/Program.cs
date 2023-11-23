using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace new_teacher
{
    public class Human
    {
        protected int id;
        protected string firstName;
        protected string lastName;
    }
    public class Employee : Human
    {
        double salary;
        public Employee(string _fName, string _lName, double _salary)
        {
            firstName = _fName;
            lastName = _lName;
            salary = _salary;
            id = 34; // Error
        }
        public void Print()
        {
            WriteLine($"ID: {id} Фамилия: {lastName}\nИмя:{firstName}\nЗаработная плата: {salary} $");
        }
    }
    class Manager : Employee
    {
        string fieldActivity;
        public Manager(string _fName, string _lName, double _salary, string _activity) : base(_fName, _lName, _salary)
        {
            fieldActivity = _activity;
        }
        public void ShowManager()
        {
            WriteLine($"Менеджер. Сфера деятельности:{fieldActivity}");
        }
    }
    class Scientist : Employee
    {
        string scientificDirection;
        public Scientist(string _fName, string _lName, double _salary, string _direction) : base(_fName, _lName, _salary)
        {
            scientificDirection = _direction;
        }
        public void ShowScientist()
        {
            WriteLine($"Ученый. Научное направление: {scientificDirection}");
        }
    }
    class Specialist : Employee
    {
        string qualification;
        public Specialist(string _fName, string _lName, double _salary, string _qualification) : base(_fName, _lName, _salary)
        {
            qualification = _qualification;
        }
        public void ShowSpecialist()
        {
            WriteLine($"Специалист. Квалификация: {qualification}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager("John", "Doe", 3500, "продукты питания");
            Employee[] employees = { manager,
                                       new Scientist("Jim", "Beam", 4253, "история"),
                                       new Specialist("Jack", "Smith", 2587.43,"физика")
};
            foreach (Employee item in employees)
            {
                item.Print();
                //item.ShowScientist(); Error
                //try
                //{
                //    ((Specialist)item).
                //    ShowSpecialist(); // Способ №1
                //}
                //catch
                //{
                //}
                //Scientist scientist = item as Scientist; // Способ №2
                //if (scientist != null)
                //{
                //    scientist.ShowScientist();
                //}
                //if (item is Manager) // Способ №3
                //{
                //    (item as Manager).ShowManager();
                //}
            }
        }
    }
}
