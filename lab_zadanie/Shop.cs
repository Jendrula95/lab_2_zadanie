using System;
using System.Collections.Generic;
using System.Text;

namespace lab_zadanie
{
    internal class Shop : IThing
    {
        private string name;
        private Person[] person;
        private Product[] products;
        public string Name { get { return name; } }
        public Shop(string name,Person[]person, Product[] products)
        {
            this.name = name;
            this.person = person;
            this.products = products;
        }
        public void Print()
        {
            Console.WriteLine("Shop : " + this.name);
            Console.WriteLine("--People--");
            foreach (var p in person)
            {
                p.Print("\t");
            }
            foreach(var p in products) { p.Print("\t");}
        }

    }
}
