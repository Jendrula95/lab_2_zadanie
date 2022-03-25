using System;
using System.Collections.Generic;
using System.Text;

namespace lab_zadanie
{
    internal class Buyer : Person
    {
        protected List<Product> products = new List<Product>();
        public Buyer(string name,int age): base(name,age)
        {
           
        }
        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }
        public void RemoveProduct(int index)
        {
            this.products.RemoveAt(index);
        }
       public override void Print(string prefix)
        {
            Console.WriteLine(prefix+"Buyer: "+ this.Name+" ( " + this.Age.ToString() + "y.o." + ")");
            if (products.Count > 0)
            {
                Console.WriteLine(prefix + " --Products: --");
                foreach(var p in products)
                {
                    p.Print(prefix + "\t");
                }
            }
        }

    }
}
