using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic.System.IO
{
    class BinaryWriterAndBinaryReader
    {
        // Lớp BinaryWriter ghi dữ liệu vao file voi định dạng nhị phân
        public void WriteToFileWithBinaryWriter(string filePath)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
            }

            Console.WriteLine("Data written successfully");
        }

        // Lớp BinaryReader được sử dụng để đọc dữ liệu dạng nhị phân từ luồng
        public void ReadFromFileWithBinaryReader(string filePath)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
    }
}
