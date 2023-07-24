using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic.SerializeAndDeserialize
{
    // Serialization là một quá trình để chuyển đổi một cấu trúc dữ liệu hoặc đối tượng thành một định dạng có thể lưu trữ được
    // sau đó nó có thể được phục hồi để trở lại trạng thái ban đầu trong một môi trường khác thông qua quá trình deserialization

    // Mọi đối tượng muốn được serialize đều phải được khai báo kèm theo attribute[Serializable]
    // Nếu bạn muốn loại trừ một thành phần (method, field, property,…) không muốn được serialize, bạn có thể đánh dấu chúng bằng attribute [NonSerialized].

    // De override qua trinh serialize va deserialize, chung ta co the cai dat cac method tu ISerializable interface
    // Interface này chứa phương thức GetObjectData() mà quá trình serialize sẽ gọi đến khi được thực thi
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
}
