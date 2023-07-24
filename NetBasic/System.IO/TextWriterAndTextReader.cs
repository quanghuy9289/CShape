using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic.System.IO
{
    class TextWriterAndTextReader
    {
        // TextWriter là một lớp trừu tượng => ko tao instance truc tiep tu no, ma phai tao doi tuong tu lop con cua no (StreamWriter)
        // TextWriter được sử dụng để ghi văn bản hoặc chuỗi ký tự liên tiếp vào tập tin
        public void WriteToFileWithTextWriter(string filePath)
        {
            using (TextWriter tw = File.CreateText(filePath))
            {
                tw.WriteLine("Hello C#!");
                tw.WriteLine("Write to file with TextWriter");
            }

            Console.WriteLine("Data written successfully");
        }

        // TextReader được sử dụng để đọc văn bản hoặc chuỗi ký tự liên tiếp tu tập tin
        public void ReadFromFileWithTextReader(string filePath)
        {
            using (TextReader tr = File.OpenText(filePath))
            {
                Console.WriteLine(tr.ReadToEnd()); // doc cho toi het stream

                // doc tung dong cho toi khi het stream
                string line = tr.ReadLine(); // luc nay line se null vi o tren ReadToEnd() da doc het stream
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = tr.ReadLine();
                }
            }
        }
    }
}
