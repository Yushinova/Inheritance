using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Group
    {
        public List<Human> group = new List<Human>();
        public void AddHuman(Human human)//прежде чем добавлять, нужно выяснить нет ли его уже в списке!
        {
            group.Add(human);
        }
     
        public List<Human> GetGroup() { return group; }
       
        public void ShowGroup()//надо бы разные для каждого сделать
        {
            Console.WriteLine("Teachers: ");

            foreach (var it in group)
            {
                Console.WriteLine(it.GetType()+": "+it.ToString());
            }
        }
    }
}
