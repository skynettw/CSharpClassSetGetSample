using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mytest
{
    class Person
    {
        private string name;
        private double height;
        private double weight;
        private int age;
        public static int count = 0;

        public Person(string n, double h, double w, int a)
        {
            this.name = n;
            this.height = h;
            this.weight = w;
            this.Age = a;
            count++;
        }

        public int Age
        {
            get { return age;  }
            set {
                this.age = value;
            }
        }
    }
}
