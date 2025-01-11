using System;
using System.Text;

namespace BT1
{
    // Lớp Dice đại diện cho xúc xắc
    public class Dice
    {
        // Thuộc tính: số mặt của xúc xắc
        private int sides;

        // Constructor: khởi tạo số mặt
        public Dice(int sides)
        {
            
            if (sides < 1)
                throw new ArgumentException("Số nút phải lớn hơn 0.");
            this.sides = sides;
        }

        // Phương thức Roll: trả về số ngẫu nhiên từ 1 đến số mặt
        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, sides + 1); // Random từ 1 đến sides
        }
    }

    // Lớp chứa hàm Main để chạy chương trình
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nút của xúc xắc:");
            int numberOfSides;

            // Kiểm tra đầu vào từ người dùng
            while (!int.TryParse(Console.ReadLine(), out numberOfSides) || numberOfSides < 1)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương lớn hơn 0:");
            }

            // Tạo đối tượng Dice
            Dice dice = new Dice(numberOfSides);

            // Tung xúc xắc và in kết quả
            Console.Write("Kết quả của lần tung xúc xắc:");
            Console.WriteLine(dice.Roll());
            Console.ReadLine();
        }
    }
}
