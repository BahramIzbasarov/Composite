using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite : Component
    {

        private List<Component> components = new List<Component>();
        public Composite(string name) : base(name)
        {
            DirectoryInfo dir = new DirectoryInfo(name);
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (var item in files)
            {
                components.Add(new Leaf(item.Name, item.Length));
                size += item.Length;
            }
            foreach (var item in dirs)
            {
                components.Add(new Composite($"{name}\\{item.Name}"));
                size += components.Last().Size;
                //FileInfo[] f = item.GetFiles();
                //foreach (var item1 in f)
                //{
                //    size += item1.Length;
                //}
            }
        }

        public List<Component> Files
        {
            get => components;
            set => components = value;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + "     " + size + "b");

            foreach (Component component in components)
            {
                component.Display(depth + 2);
            }
        }

        internal void Add(DirectoryInfo dir)
        {
            throw new NotImplementedException();
        }

        public void Add(Component component)
        {
            components.Add(component);
        }

        public void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}
