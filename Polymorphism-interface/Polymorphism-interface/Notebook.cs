using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_interface
{
    internal class Notebook : INotebook,ICommon
    {
        public void GetById(int id)
        {
            Console.WriteLine("Notebook");
        }

        public void GetName()
        {
            Console.WriteLine("Name Book");
        }
    }
}
