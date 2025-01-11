using System;
using System.Text;

namespace VDXS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Số người tham gia:");
                int songuoi = int.Parse(Console.ReadLine());

                if (songuoi <= 0)
                {
                    Console.WriteLine("Số người tham gia phải lớn hơn 0!");
                    return;
                }

                string[] nguoiChoi = new string[songuoi];
                for (int i = 0; i < songuoi; i++)
                {
                    Console.Write($"Người chơi số {i + 1} là: "); // Sửa `i` thành `i + 1` để hiển thị đúng số thứ tự
                    nguoiChoi[i] = Console.ReadLine();
                }

                XucXac xx1 = new XucXac();
                xx1.SoMat = songuoi; // Gán số mặt xúc xắc bằng số người chơi
                int SoNgauNhien = xx1.DoXucXac();

                Console.WriteLine("Số ngẫu nhiên được chọn là: " + SoNgauNhien);

                // Kiểm tra giá trị hợp lệ
                if (SoNgauNhien >= 1 && SoNgauNhien <= songuoi)
                {
                    Console.WriteLine("Người chơi có tên là: " + nguoiChoi[SoNgauNhien - 1]);
                }
                else
                {
                    Console.WriteLine("Lỗi: Giá trị ngẫu nhiên không hợp lệ.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập vào số nguyên hợp lệ.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }

    // Định nghĩa class XucXac
    class XucXac
    {
        public int SoMat { get; set; } // Số mặt xúc xắc

        public int DoXucXac()
        {
            Random random = new Random();
            return random.Next(1, SoMat + 1); // Trả về giá trị từ 1 đến SoMat
        }
    }
}
