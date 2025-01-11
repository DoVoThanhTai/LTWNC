using System;
using System.Text;

namespace BT4
{
    // Lớp Fraction để xử lý phân số
    public class Fraction
    {
        // Thuộc tính: Tử số và Mẫu số
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        // Constructor: khởi tạo phân số với tử số và mẫu số
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Mẫu số không thể bằng 0.");

            Numerator = numerator;
            Denominator = denominator;
            Simplify(); // Chuẩn hóa phân số ngay khi khởi tạo
        }

        // Phương thức nhập phân số
        public void Input()
        {
            Console.Write("Nhập tử số: ");
            Numerator = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số (khác 0): ");
            Denominator = int.Parse(Console.ReadLine());
            if (Denominator == 0)
                throw new ArgumentException("Mẫu số không thể bằng 0.");
            Simplify();
        }

        // Phương thức hiển thị phân số dưới dạng (A/B)
        public void Display()
        {
            Console.WriteLine($"Phân số: ({Numerator}/{Denominator})");
        }

        // Phương thức hiển thị phân số dưới dạng số thập phân
        public void DisplayAsDecimal()
        {
            Console.WriteLine($"Dạng số thập phân: {((double)Numerator / Denominator):F2}");
        }

        // Phương thức cộng hai phân số
        public Fraction Add(Fraction other)
        {
            int numerator = Numerator * other.Denominator + other.Numerator * Denominator;
            int denominator = Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }

        // Phương thức trừ hai phân số
        public Fraction Subtract(Fraction other)
        {
            int numerator = Numerator * other.Denominator - other.Numerator * Denominator;
            int denominator = Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }

        // Phương thức nhân hai phân số
        public Fraction Multiply(Fraction other)
        {
            int numerator = Numerator * other.Numerator;
            int denominator = Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }

        // Phương thức chia hai phân số
        public Fraction Divide(Fraction other)
        {
            if (other.Numerator == 0)
                throw new ArgumentException("Không thể chia cho 0.");
            int numerator = Numerator * other.Denominator;
            int denominator = Denominator * other.Numerator;
            return new Fraction(numerator, denominator);
        }

        // Phương thức chuẩn hóa phân số
        private void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator)); // Tìm ước chung lớn nhất
            Numerator /= gcd;
            Denominator /= gcd;

            // Đảm bảo mẫu số luôn dương
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        // Hàm tính ước chung lớn nhất (GCD)
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

    // Lớp Program để kiểm tra lớp Fraction
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập phân số thứ nhất:");
            Fraction fraction1 = new Fraction(1, 1);
            fraction1.Input();

            Console.WriteLine("Nhập phân số thứ hai:");
            Fraction fraction2 = new Fraction(1, 1);
            fraction2.Input();

            // Hiển thị hai phân số
            Console.WriteLine("Phân số thứ nhất:");
            fraction1.Display();
            fraction1.DisplayAsDecimal();

            Console.WriteLine("Phân số thứ hai:");
            fraction2.Display();
            fraction2.DisplayAsDecimal();

            // Phép cộng
            Fraction sum = fraction1.Add(fraction2);
            Console.WriteLine("Kết quả cộng:");
            sum.Display();

            // Phép trừ
            Fraction difference = fraction1.Subtract(fraction2);
            Console.WriteLine("Kết quả trừ:");
            difference.Display();

            // Phép nhân
            Fraction product = fraction1.Multiply(fraction2);
            Console.WriteLine("Kết quả nhân:");
            product.Display();

            // Phép chia
            Fraction quotient = fraction1.Divide(fraction2);
            Console.WriteLine("Kết quả chia:");
            quotient.Display();
            Console.ReadLine();
        }
    }
}
