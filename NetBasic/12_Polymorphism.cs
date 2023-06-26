using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    /*
     * Da hinh - Polymorphism - dùng để chỉ việc ứng xử khác nhau của các đối tượng trong những lớp kế thừa từ một lớp cơ sở khi một phương thức chung được gọi
     * Co 2 loai da hinh trong C#:
     *  + Da hinh thoi gian bien dich: bang cach overload method va overload toan tu => rang buoc tinh, rang buoc som
     *  + Da hinh thoi gian chay: bang cach override method => lien ket dong, lien ket muon
     */
    class Shape
    {
        public string color = "white";
        // method virtual will be overrided in child class
        public virtual void draw()
        {
            Console.WriteLine("drawing...");
        }
    }

    class Rect : Shape
    {
        public new string color = "red";
        // polymorphism
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }

    class Circle : Shape
    {
        public new string color = "yellow";
        // polymorphism
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
}
