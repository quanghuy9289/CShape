using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    public class Account
    {
        public int id;
        public String name;
        public static float rateOfInterest;
        public Account(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        /*
         * Static constructor dung de khoi tao cac doi tuong static
         * Static constructor ko dc co tham so
         * Ham nay chi duoc thuc hien 1 lan => duoc goi tu dong boi ct, truoc khi obj dau tien dc khoi tao, hoac bat ki thanh vien tinh nao dc tham chieu
         *      vi dc goi ngam nen ko the debug dc
         */
        static Account()
        {
            rateOfInterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + rateOfInterest);
        }
    }
}
