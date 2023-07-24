using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic.System.IO
{
    class StringWriterAndStringReader
    {
        // Lớp này được sử dụng để ghi và xử lý dữ liệu chuỗi chứ không phải là tập tin.
        // StringWriter là lớp dẫn xuất của lớp TextWriter.
        // Dữ liệu chuỗi được ghi bởi lớp StringWriter được lưu trữ vào StringBuilder
        // Mục đích của lớp này là thao tác chuỗi và lưu kết quả vào StringBuilder
        public void WriteToStringWithStringWriter()
        {
            string text = "Hello, Welcome to the javapoint \n" +
                "It is nice site. \n" +
                "It provides technical tutorials";

            // Creating StringBuilder instance  
            StringBuilder sb = new StringBuilder();

            // Passing StringBuilder instance into StringWriter  
            StringWriter writer = new StringWriter(sb);

            // Writing data using StringWriter  
            writer.WriteLine(text);
            writer.Flush();

            // Closing writer connection  
            writer.Close();

            // Creating StringReader instance and passing StringBuilder  
            StringReader reader = new StringReader(sb.ToString());
            // Reading data  
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }

        // StringReader là lớp con của lớp TextReader.
        public void ReadFromStringWithStringReader()
        {
            StringWriter str = new StringWriter();
            str.WriteLine("Hello, this message is read by StringReader class");
            str.Close();
            // Creating StringReader instance and passing StringWriter  
            StringReader reader = new StringReader(str.ToString());
            // Reading data  
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
