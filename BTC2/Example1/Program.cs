using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, Tong;
            Console.OutputEncoding = Encoding.UTF8;
            
                Console.Write("Nhập số thứ nhất: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhập số thứ hai: ");
                b = Convert.ToDouble(Console.ReadLine());

                Tong = a + b;

                Console.WriteLine($"Tổng của {a} và {b} là: {Tong}");
            

        }
    }
}
           


