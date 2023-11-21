using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Student : Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }  //посещаемость

        public Student
            (
            string last_name, string first_name, int age,
            string speciality, string group, double rating, double attendance
            ) : base(last_name, first_name, age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine("SConstructor:\t" + GetHashCode());
        }
        public override string ToString()
        {
            return $"{base.ToString()} Специальность: {Speciality} Группа: {Group} Успеваемость: {Rating} Посещаеость: {Attendance}";
        }
        public override string ToWrite()
        {
            return $"{base.ToWrite()},{Speciality},{Group},{Rating},{Attendance}";
        }
    }
}
