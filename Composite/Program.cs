using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("folders");

            root.Add(new Leaf("f1", 54));
            
        }
    }
}
