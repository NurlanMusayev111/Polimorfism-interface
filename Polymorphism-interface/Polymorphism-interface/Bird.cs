using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_interface
{
    public class Bird : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bird Sound");
        }
    }
}
