using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new ArrayList();
            ds.Add(new Product("A", 25, 3));
            ds.Add(new Product("B", 2.5, 4));
            foreach (Product p in ds)
            {
                Console.WriteLine("Product" + p);
            }
            foreach (Product p in ds)
            {
                p.Display();
            }
            Console.ReadLine();
        }
    }
}
