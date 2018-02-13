using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("C:\\Users\\izba_cr95\\Documents\\project");
            foreach (var item in root.Files)
            {
                item.Display(1);
            }
        }
    }
}
