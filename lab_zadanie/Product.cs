using System;
using System.Collections.Generic;
using System.Text;

namespace lab_zadanie
{
    abstract class Product : IThing
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            
        }
        public Product(string name)
        {
            this.name = name;
        }
        public abstract void Print(string prefix);
      
    }
}
