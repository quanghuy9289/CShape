using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic.Collections
{
    // List<T> là lớp triển khai các giao diện IList, ICollection, IEnumerable
    // quản lý danh sách các đối tượng cùng kiểu

    // lớp Product hỗ trợ so sánh với sản phẩm khác nên triển khai IComparable
    // cho phép hiện lấy một chuỗi thông tin bằng ToString với định dạng nào đó nên triển khai giao diện IFormattable
    public class Product : IComparable, IFormattable
    {
        // properties
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }

        public Product(int id, string name, decimal price, string origin)
        {
            ID = id; Name = name; Price = price; Origin = origin;
        }

        /// <summary>
        /// compare voi product khac ve gia, gia cao xep truoc
        /// </summary>
        /// <param name="otherProduct"></param>
        /// <returns>
        /// 0 - bang gia
        /// < 0 - gia cao hon other (dung truoc trong ds)
        /// > 0 - gia thap hon other (dung sau trong ds)
        /// </returns>
        public int CompareTo(object obj)
        {
            Product otherProduct = (Product)obj;
            decimal delta = this.Price - otherProduct.Price;
            if (delta > 0) return -1; // tra ve so < 0 de dung truoc trong ds
            if (delta < 0) return 1;
            return 0;
        }

        /// <summary>
        /// In ra product theo xuat xu hoac theo ten
        /// </summary>
        /// <param name="format">
        /// "O": xuat theo xuat xu truoc (origin)
        /// "N": xuat theo ten truoc (name)
        /// </param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null) format = "O"; // default xuat theo xuat xu truoc
            switch (format.ToUpper())
            {
                case "O": // xuat xu truoc
                    return $"Xuất xứ: {Origin} - Tên: {Name} - Giá: {Price} - ID: {ID}";
                case "N": // theo ten
                    return $"Tên: {Name} - Xuất xứ: {Origin} - Giá: {Price} - ID: {ID}";
                default:
                    throw new FormatException("Khong ho tro format nay");
            }
        }

        override public string ToString() => $"{Name} - {Price}";

        public string ToString(string format) => this.ToString(format, null);
    }

    class SearchNameProduct
    {
        string nameSearch;
        public SearchNameProduct(string name)
        {
            nameSearch = name;
        }

        // ham gan cho delegate
        public bool search(Product p)
        {
            return p.Name == nameSearch;
        }

    }

    class ListExample
    {
        public List<Product> InitAndPrintList()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Iphone 6", 100, "Trung Quoc"));
            products.Add(new Product(2, "Iphone 7", 200, "Trung Quoc"));
            products.Add(new Product(3, "Iphone 8", 300, "Trung Quoc"));

            // add range
            var list = new Product[]
            {
                new Product(4, "Galaxy 7", 150, "Viet Nam"),
                new Product(5, "Galaxy 8", 250, "Viet Nam"),
            };
            products.AddRange(list);

            // chen phan tu
            products.Insert(3, new Product(6, "Macbook Pro 2022", 1000, "My"));

            // duyet list
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString("O")); // in theo xuat xu
            }

            // xoa phan tu
            products.RemoveAt(0);

            return products;
        }

        public void SearchProduct(List<Product> products)
        {
            // tim kiem
            Product p = products.Find((Product ob) => { return ob.Name == "Galaxy 8"; });
            if (p != null)
            {
                Console.WriteLine("(found) " + p.ToString("O"));
            }

            // tim cac phan tu co gia tren 200
            List<Product> ps = products.FindAll(x => x.Price > 200);
            Console.WriteLine("Cac phan tu co gia tren 200");
            foreach (Product product in ps)
            {
                Console.WriteLine(product.ToString("N")); // in theo name
            }

            // tuy bien hon bang cach implement 1 delegate
            Console.WriteLine("Tim theo delegate");
            Product p1 = products.Find(new SearchNameProduct("Galaxy 8").search); Console.WriteLine(p1.ToString());
            Product p2 = products.Find(new SearchNameProduct("Macbook Pro 2022").search); Console.WriteLine(p2.ToString());
        }
        public void SortProduct(List<Product> products)
        {
            // sap xep mac dinh
            Console.WriteLine("Sap xep product");
            products.Sort(); // su dung ham CompareTo da duoc define trong lop Product
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString("N")); // in theo name
            }

            // define 1 compareTo function de delegate
            Console.WriteLine("Sap xep product theo 1 delegate");
            products.Sort(
                (p1, p2) => {
                    if (p1.ID > p2.ID)
                        return 1;
                    else if (p1.ID == p2.ID)
                        return 0;
                    return -1;
                }
            );
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString("N")); // in theo name
            }
        }
    }
}
