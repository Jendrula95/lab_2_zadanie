using System;
using System.Collections.Generic;
using System.Text;

namespace lab_zadanie
{
    internal class Fruit : Product
    {
        private int count;
        public int Count { get
            { return count; }}
        public Fruit(string name, int count) : base(name)
        {
            
            this.count = count;
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + this.Name + " ( " + (this.count == 1 ? "Fruit" : "Fruits") + ")"  );

        }
    }
}
