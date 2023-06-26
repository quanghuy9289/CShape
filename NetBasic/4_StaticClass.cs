using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    /*
     * Lop static chi chua cac thanh vien static
     * Lop static ko the khoi tao doi tuong => ko chua cac ham khoi tao (ke ca khoi tao mac dinh)
     * Lop static duoc niem phong (sealed)
     */
    public static class MyMath
    {
        public static float PI = 3.14f;
        public static int Cube(int n)
        {
            return n * n * n;
        }
    }
}
