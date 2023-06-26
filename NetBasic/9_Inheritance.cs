using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    // trong C# ko cho phep 1 luc ke thua nhieu lop, vd BabyDog : Dog, Animal. Da ke thua dc the hien thong qua da thua ke
    class BabyDog : Dog
    {
        public void weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
}
