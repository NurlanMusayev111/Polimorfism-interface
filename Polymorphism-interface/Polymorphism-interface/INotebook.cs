using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_interface
{
    public interface INotebook :ICommon
    {
        void GetById(int id);
    }
}
