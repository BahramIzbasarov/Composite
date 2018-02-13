using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Component
    {
        protected string name;
        protected long size;

        public long Size { get => size; set => size = value; }

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
