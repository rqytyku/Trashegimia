using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trashegimia
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Shape s = new Trekendeshi(3,5);
            s.Print();
            Console.WriteLine("Syprina eshte:" + s.S()); 
            Console.WriteLine("-------------------");
            Shape s2 = new Rrethi(6);
            s2.Print();
            Console.WriteLine("Syprina eshte:" + s2.S());
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.ReadLine();
 
        }
    }
}
