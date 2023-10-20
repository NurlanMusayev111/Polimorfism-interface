using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_interface
{
    internal class Book : Test ,IBook, ICommon
    {
        public void GetName()
        {
            Console.WriteLine("Name Book");
        }

        public void ShowAll()
            {
            Console.WriteLine("Show books");
            }
    }
}
