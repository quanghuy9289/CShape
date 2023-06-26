using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    /*
     * Điểm giống nhau giữa Struct và Class :
- Đều che giau thông tin bên trong bằng những dữ liệu thành viên là các field.
- Đều chứa các phương thức (method) và các thuộc tính (Property).
- Đều có thể thực hiện các giao diện (implement interface)
- Đều có hàm khởi tạo

    Điểm khác nhau giữa Struct và Class :
- Hàm tạo của Struct bắt buộc phải có tham số
- Struct là kiểu dữ liệu tham trị được chứa trong vùng nhớ Stack còn Class là kiểu dữ liệu tham chiếu được chứa trong vùng nhớ Heap
- Struct không hổ trợ kế thừa từ một Class hay Struct khác
- Struct không hổ trợ hàm hủy

    Dung khi nao?
- Doi voi struct: khi goi ham voi tham so la struct obj se dc push vao stack
- Doi voi class: khi goi ham voi tham so la class obj se dc push vao heap
- Nhung heap thi ko nhanh bang stack, nen thuong du lieu nho, su dung thuong xuyen thi co the dung stack (struct). Vd: struct TOADO, struct PHANSO
     */

    public struct Rectangle
    {
        public int width, height;

        // Hàm tạo của Struct bắt buộc phải có tham số
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public void areaOfRectangle()
        {
            Console.WriteLine("Area of Rectangle is: " + (width * height));
        }
    }
}
