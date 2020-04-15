using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trashegimia
{
    public class Trekendeshi: Shape
    {
        public double Gjatesia { get; set; }
        public double Gjeresia { get; set; }
 
        public Trekendeshi(double a, double b)
        {
            Name = "Trekendesh";
            Gjatesia = a;
            Gjeresia = b;
        }
 
        public override double S()
        {
            return Gjatesia * Gjeresia;
        }

        public override void Print()
        {
          
            base.Print();
            Console.WriteLine("Gjatesia :" + Gjatesia);
            Console.WriteLine(" Gjeresia:" + Gjeresia);
           
        }
    }
    
}
