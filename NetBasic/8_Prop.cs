using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    class Employee
    {
        // cac field private ko dc truy cap truc tiep tu ben ngoai ma phai thong qua Prop
        private string name;
        private static int counter;

        public Employee()
        {
            Counter++;
        }

        // Prop ko dc luu tru
        // no la phan mo rong cua cac field va dc truy cap nhu cac field
        public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                name = value + " hiepsiit";
            } 
        }
        public int Age { get; set; }
        public static int Counter { get => counter; set => counter = value; }
    }
}
