using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic.Collections
{
    // ArrayList về cơ bản, nó là một sự thay thế cho một mảng
    // Khac mang o cho no tự động thay đổi kích thước. Nó cũng cho phép cấp phát bộ nhớ động, thêm, tìm kiếm và sắp xếp các item trong một list
    class ArrayListExample
    {
        public void CreateAndPrintArrayList()
        {
            ArrayList al = new ArrayList();

            // add elements
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Suc chua: {0}", al.Capacity);
            Console.WriteLine("So phan tu: {0}", al.Count);

            Console.WriteLine("Noi dung");
            foreach(var i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sap xep noi dung arrayList");
            al.Sort();
            foreach (var i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
