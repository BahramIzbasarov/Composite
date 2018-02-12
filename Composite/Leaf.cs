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
        private int size;

        public Leaf(string name, int size) : base(name)
        {
            this.name = name;
            this.size = size;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public int Size { get => size; set => size = value; }
    }
}
