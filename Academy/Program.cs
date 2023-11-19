using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher A = new Teacher("Ivanova", "Anna", 28, "C++", 85);
            Group group = new Group();
            group.AddTeacher(A);
            group.ShowGroup();
        }
    }
}
