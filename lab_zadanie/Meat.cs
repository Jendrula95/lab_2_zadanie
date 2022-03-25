using System;
using System.Collections.Generic;
using System.Text;

namespace lab_zadanie
{
    internal class Meat : Product
    {
        private double weight;
        public double Weight { get { return weight; } }

        public Meat(string name, double weight) : base(name)
        {
            this.weight = weight;
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + this.Name + " ( " + this.weight + " kg " + ")");
        }
    }
}
