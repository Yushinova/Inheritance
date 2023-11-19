using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Group
    {
        public List<Teacher> teachers = new List<Teacher>();
        public List<Student> students = new List<Student>();
        public List<Graduate> graduates = new List<Graduate>();
        public void AddTeacher(Teacher teacher)//прежде чем добавлять, нужно выяснить нет ли его уже в списке!
        {
            teachers.Add(teacher);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddGraduate(Graduate graduate)
        {
            graduates.Add(graduate);
        }
        List<Teacher> GetTeachers() { return teachers; }
        List<Student> GetStudents() { return students; }
        List<Graduate> GetGraduates() {  return graduates; }
        public void ShowGroup()
        {
            Console.WriteLine("Teachers: ");
            if(teachers.Count > 0)
            {
                foreach (var it in teachers)
                {
                    Console.WriteLine(it.ToString());
                }
            }
            //Console.WriteLine("Students: ");
            //foreach (var it in students)
            //{
            //    Console.WriteLine(it.ToString());
            //}
            //Console.WriteLine("Graduates: ");
            //foreach (var it in teachers)
            //{
            //    Console.WriteLine(it.ToString());
            //}
        }
    }
}
