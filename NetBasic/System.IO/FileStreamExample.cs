using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic.System.IO
{
    // Lớp FileStream cung cấp một luồng cho thao tác trên tập tin
    // FileStream có thể được sử dụng để thực hiện các thao tác đọc và ghi đồng bộ và không đồng bộ
    class FileStreamExample
    {
        public void WriteByteToFile(string filePath)
        {
            FileStream f = new FileStream(filePath, FileMode.OpenOrCreate); //creating file stream
            if (f != null)
            {
                for(int i=65; i<=90; i++)
                {
                    f.WriteByte((byte)i); //writing byte into stream  
                }
                f.Close(); //closing stream
            }
        }

        public void ReadByteFromFile(string filePath)
        {
            FileStream f = new FileStream(filePath, FileMode.OpenOrCreate); //creating file stream
            if (f != null)
            {
                int i = 0;
                while((i = f.ReadByte()) != -1) // read until end of file
                {
                    Console.Write((char)i);
                }

                f.Close();
            }
        }
    }
}
