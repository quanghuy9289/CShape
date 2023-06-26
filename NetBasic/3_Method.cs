using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    public class Method
    {
        // truyền tham tri
        public void Show(int num)
        {
            num = num + 1;
            Console.WriteLine("In show num change to " + num);
        }

        // truyền tham chieu
        public void Show(ref int val)
        {
            val *= val;
            Console.WriteLine("In show val change to " + val);
        }

        // out params, giống ref là truyền tham chiếu, có thể dùng làm giá trị trả về sau khi kết thúc hàm
        //
        // khác với ref ở chỗ:
        // + biến truyền vào với out keywork ko cần khởi tạo giá trị ban đầu
        // + param với out keywork phải được khởi tạo bên trong hàm
        public void ShowWithReturnInParam(out int val)
        {
            int square = 5;
            val = square;
            val *= val;
        }

        // hàm trả về nhiều giá trị với out params
        public void ShowWithReturnMultiValue(out int a, out int b)
        {
            int square = 5;
            a = square;
            b = square;
            a *= a;
        }

        // Cho phép truyền nhiều param vào bên trong hàm mà ko xác định được số lượng param, chúng ta dùng từ khóa params
        // tham số được truyền vào đi kèm với từ khóa params chỉ được phép là mảng một chiều.
        public void ShowWithParams_SameDataType(params int[] items) // Params Paramater  
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void ShowWithParams_DifferentDataType(params object[] items) // Params Paramater  
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
