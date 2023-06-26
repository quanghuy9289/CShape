using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            // goto command
            //ConditionStructure obj = new ConditionStructure();
            //obj.GoToInstruction();
            */

            /*
            // method
            Method m = new Method();
            int x = 10;
            m.Show(x);
            Console.WriteLine("Out show x change to " + x);

            int y = 10;
            m.Show(ref y);
            Console.WriteLine("Out show y change to " + y);

            // ko cần khởi tạo z
            m.ShowWithReturnInParam(out int z);
            Console.WriteLine("Out ShowWithReturnInParam z = " + z);

            // hàm có thể trả về nhiều giá trị
            m.ShowWithReturnMultiValue(out int a, out int b);
            Console.WriteLine("Out ShowWithReturnMultiValue a = " + z + " b = " + b);

            // truyền số lượng tham số không xác định với params keyword
            m.ShowWithParams_SameDataType(1, 2, 3, 4, 5);
            m.ShowWithParams_DifferentDataType(1, "hello", 2, 4.5, 'A');
            */

            /*
            // Array
            //ArraryClass arrayObj = new ArraryClass();
            //arrayObj.InitAndScanArray();
            //arrayObj.InitArray();
            //arrayObj.InitAndScanMultiDimentionArray();
            //arrayObj.InitAndScanJaggedArray();
            */

            /*
            // Static class
            Console.WriteLine("Value of PI is: " + MyMath.PI); // ko can khoi tao doi tuong => tiet kiem bo nho
            Console.WriteLine("Cube of 3 is: " + MyMath.Cube(3));
            */

            /*
            //static constructor
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Mahesh");
            a1.display();
            a2.display();
            */

            /*
            // struct
            Rectangle r = new Rectangle(10,5);
            r.areaOfRectangle();
            */

            /*
            // enum
            int x = (int)Season.WINTER; // phai ep kieu
            int y = (int)Season.SUMMER;
            Console.WriteLine("WINTER = {0}", x); // 0
            Console.WriteLine("SUMMER = {0}", y); // 2

            // print name of enum element
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }

            // print value of enum element
            foreach (int d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(d);
            }

            // co the duyet tung enum element va su dung sau do
            foreach (Days d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(d); // Sun, Mon...
                Console.WriteLine(((int)d)); // 1,2,3 (vi gia tri bat dau tu 1)
            }
            */

            /*
            // prop
            Employee e1 = new Employee();
            e1.Name = "huyngo";
            Console.WriteLine("Employee name: " + e1.Name);

            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Employee e4 = new Employee();
            Console.WriteLine("Counter: " + Employee.Counter);
            */

            /*
            // inheritance
            Dog d1 = new Dog();
            d1.eat();
            d1.bark();

            BabyDog bd = new BabyDog();
            bd.eat();
            bd.bark();
            bd.weep();
            */

            /*
            // Aggregation: HAS-A
            Address ad = new Address("G-13, Sec-3", "Noida", "UP");
            User u = new User(1, "HuyNgo", ad);
            u.display();
            */

            /*
            // base keyword
            Milo milo = new Milo();
            milo.ShowColor();
            */

            // Polymorphism
            // da hinh thoi gian chay
            Shape s = new Shape();
            s.draw();
            s = new Rect();
            s.draw();
            s = new Circle();
            s.draw();

            // da hinh thoi gian chay KO AP DUNG voi field
            Shape s1 = new Rect();
            Console.WriteLine(s1.color); // white - base class
            s1 = new Circle();
            Console.WriteLine(s1.color); // white - base class

            Console.ReadLine();
        }
    }
}
