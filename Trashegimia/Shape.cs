using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trashegimia
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("Ky eshte nje "+ Name);
        }
        public abstract double S();
    }
}
