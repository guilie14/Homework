using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Product
    {
        public string Name; /*{ set; get; }*/
        public double Cost; /*{ set; get; }*/
        public int Onhand; /*{ set; get; }*/
        public Product(string Name, double Cost, int Onhand)
        {
            this.Name = Name;
            this.Cost = Cost; 
            this.Onhand = Onhand; 
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}, Cost: {1}, On Hand: {2} ", Name, Cost, Onhand);
        }
        public override string ToString()
        {
            return string.Format("cost {0,-10:c}  on hand: {1, -10}  name {2}", Cost, Onhand, Name);
        }

    }
}
