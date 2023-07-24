using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    class InternalTest
    {
        // public: truy cap o bat ki dau
        // protected: trong cung lop hoac cac lop dan xuat moi truy suat duoc
        // internal: trong cung namespace la co the truy suat duoc
        // protected internal: hoac cung namespace / hoac cung lop / hoac cac lop dan xuat
        // private: chi trong pham vi lop
        protected internal string name = "test";
        protected internal void Msg(string str)
        {
            Console.WriteLine("Hello " + str);
        }
    }

    class Test
    {
        public void TestMethod()
        {
            InternalTest t = new InternalTest();
            Console.WriteLine("Hello " + t.name); // cung namespace
            t.Msg("Ronaldo");
        }
    }
}
