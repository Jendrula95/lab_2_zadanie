using System;
using System.Collections.Generic;
using System.Text;

namespace lab_zadanie
{
    abstract class Person : IThing
    {
        private string name;
        private int age;
        public string Name{
            get { return name; }
        }
        public int Age { get
            {
                return age;
            }
            }
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public bool Equals(Person obj)
        {
            return obj.name == this.name && obj.age == this.age;
        }
        public abstract void Print(string prefix);
    }
}
