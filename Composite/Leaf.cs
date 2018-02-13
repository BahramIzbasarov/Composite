using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Leaf : Component
    {
        
        public Leaf(string name, long size) : base(name)
        {
            this.name = name;
            this.size = size;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + "     " + size + "b");
        }

        
    }
}
