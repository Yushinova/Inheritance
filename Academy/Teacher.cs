using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Teacher : Human
    {
        public string Speciality { get; set; }
        public double Experience { get; set; }
        public Teacher
            (
            string last_name, string first_name, int age,
            string speciality, double experience
            ) : base(last_name, first_name, age)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine("TConstructor:\t" + GetHashCode());
        }
        public override string ToString()
        {
            return $"{base.ToString()}  специальность: {Speciality} Опыт: {Experience}";
        }
        public override string ToWrite()
        {
            return $"{base.ToWrite()},{Speciality},{Experience}";
        }
    }
}
