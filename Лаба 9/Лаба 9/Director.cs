using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_9
{
    class Director
    {       
        
        public delegate void Raise(int add);
        public event Raise Raising;

        public delegate void Penalty();
        public event Penalty Penalizing;

        public void Add(int add) => Raising(add);
        public void Minus() => Penalizing?.Invoke();

    }
    
    
}
