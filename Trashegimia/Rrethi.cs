using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trashegimia
{
    public class Rrethi : Shape
    {
        public double Rrezja { get; set; }
 
        public Rrethi(double rrezja)
        {
            Name = "Rrethi";
            Rrezja= rrezja;
        }
 
       
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Rrezja:"+ Rrezja);
       
        }
        public override double S()
        {
            return Math.PI * (Math.Pow(Rrezja, 2.0));
        }
       
    }
}
