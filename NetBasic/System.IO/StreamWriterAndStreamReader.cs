using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic.System.IO
{
    class StreamWriterAndStreamReader
    {
        // StreamWriter được sử dụng để ghi nhiều ký tự vào luồng
        // kế thừa từ lớp TextWriter và có hai phương thức đề ghi dữ liệu vào tập tin: write() và  writeln()
        public void WriteToFileWithStreamWriter(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            if (fs != null)
            {
                StreamWriter sw = new StreamWriter(fs); // default encoding is UTF-8
                if (sw != null)
                {
                    sw.WriteLine("Hello C#!");
                    sw.Close();
                }
                fs.Close();
                Console.WriteLine("Write to file successfully!");
            }
        }

        // StreamReader được sử dụng để đọc một chuỗi từ một luồng
        // Lớp này kế thừa từ lớp TextReader và có hai phương thức để đọc dữ liệu từ luồng: read() và readln()
        public void ReadFromFileWithStreamReader(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            if (fs != null)
            {
                StreamReader sr = new StreamReader(fs); // default encoding is UTF-8
                if (sr != null)
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)  // read until end stream
                    {
                        Console.WriteLine(line);
                    }
                    sr.Close();
                }
                fs.Close();
            }
        }
    }
}
