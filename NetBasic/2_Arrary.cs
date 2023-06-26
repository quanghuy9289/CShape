using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    public class ArraryClass
    {
        public void InitAndScanArray()
        {
            int[] arr = new int[5];
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;

            // duyet mang bang foreach
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        // có thể init array bằng 3 cách
        public void InitArray()
        {
            // cách 1
            int[] arr1 = new int[5] { 10, 20, 30, 40, 50 };

            // cach 2
            int[] arr2 = new int[] { 10, 20, 30, 40, 50 };

            // cach 3
            int[] arr3 = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }

        // mảng đa chiều (2D, 3D)
        public void InitAndScanMultiDimentionArray()
        {
            // tương tự mảng 1 chiều, có thể khởi tạo mảng đa chiểu theo 3 cách
            int[,] arr1 = new int[3, 3] { { 1,2,3},{ 4,5,6},{ 7,8,9} };
            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // mảng 3 chiều
            int[,,] arr4 = new int[3, 3, 3];

            // duyet mang da chieu
            // nếu dùng arr1.length nó sẽ trả về tổng số phần tử trong mảng
            Console.WriteLine("So phan tu trong multi dimention arr la " + arr1.Length); // 9
            for (int i=0; i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine(); // new line for arr
            }
        }

        // mảng Jagged (mảng trong mảng)
        public void InitAndScanJaggedArray()
        {
            int[][] arr = new int[2][]; // mảng Jagged có 2 phần tử
            // khởi tạo từng phần tử của mảng Jagged (mảng bên trong)
            // số phần tử của các mảng bên trong là bất kì, có thể ko giống nhau
            arr[0] = new int[] { 11, 21, 56, 78 };
            arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

            // khởi tạo mảng với các phần tử bên trong
            int[][] arr2 = new int[3][]
            {
                new int[]{ 11, 21, 56, 78 },
                new int[] { 2, 5, 6, 7, 98, 5 },
                new int[] { 2, 5 }
            };


            // duyet mang da chieu
            Console.WriteLine("So phan tu trong mang Jagged arr la " + arr.Length); // 2
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine(); // new line for arr
            }
        }

    }
}
