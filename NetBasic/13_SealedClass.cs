using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    /*
     * Sealed class - lop niem phong
     * Sealed class KHONG cho phep cac lop khac ke thua no (ko co con)
     * struct trong C# dc xem la sealed class => ko dc ke thua
     * 
     * sealed class hoac slealed method
     */

    // sealed class => ko cho phep ke thua
    sealed class Animal1
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    /*
    class Dog1 : Animal1 => compile error: 'Dog1': cannot derive from sealed type 'Animal1'
    {

    }
    */


    // sealed method
    class Animal2
    {
        public virtual void Eat()
        {
            Console.WriteLine("eating...");
        }
        public virtual void Run()
        {
            Console.WriteLine("running...");
        }
    }

    class Dog2:Animal2
    {
        public override void Eat()
        {
            Console.WriteLine("eating bread...");
        }

        // sealed method ko the ghi de
        // sealed method phai dung voi tu khoa override
        public sealed override void Run()
        {
            Console.WriteLine("running very fast...");
        }

        /*
        public sealed void Sleep() => Compile Time Error: 'Dog2.Sleep()' cannot be sealed because it is not an override
        {

        }
        */
    }

    class BabyDog2 : Dog2
    {
        public override void Eat()
        {
            /* sealed int x=10; => sealed ko dung cho local variable */
            Console.WriteLine("eating biscuits...");
        }

        /*
        public override void Run() => Compile Time Error: 'BabyDog2.run()': cannot override inherited member 'Dog2.run()' because it is sealed
        {
            Console.WriteLine("running slowly...");
        }
        */
    }
}
