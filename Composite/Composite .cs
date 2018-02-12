using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite : Component
    {
        private List<Component> files = new List<Component>();
        public Composite(string name) : base(name)
        {

        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in files)
            {
                component.Display(depth + 2);
            }
        }

        public void Add(Component component)
        {
            files.Add(component);
        }

        public void Remove(Component component)
        {
            files.Remove(component);
        }
    }
}
