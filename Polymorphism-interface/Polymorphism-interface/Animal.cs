﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_interface
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}
