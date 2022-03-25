using System;
using System.Collections.Generic;
using System.Text;

namespace lab_zadanie
{
    internal class Seller : Person
    {
        public Seller(string name,int age) : base(name, age)
        {
           
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Seller: " + this.Name + " ( " + this.Age.ToString() + "y.o.");
            
        }
    }
}
