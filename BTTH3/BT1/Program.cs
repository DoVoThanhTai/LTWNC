using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    using System;
    using System.Collections.Generic;

    // Lớp cơ sở trừu tượng Hình
    abstract class Hinh
    {
        protected int x, y;

        public Hinh(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void DiChuyen(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public abstract void HienThi();
        public override abstract string ToString();
    }

    // Lớp Đường thẳng
    class DuongThang : Hinh
    {
        private int x2, y2;

        public DuongThang(int x, int y, int x2, int y2) : base(x, y)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void HienThi()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Đường thẳng từ ({x}, {y}) đến ({x2}, {y2})";
        }
    }

    // Lớp Hình tròn
    class HinhTron : Hinh
    {
        private int banKinh;

        public HinhTron(int x, int y, int banKinh) : base(x, y)
        {
            this.banKinh = banKinh;
        }

        public override void HienThi()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Hình tròn có tâm ({x}, {y}) và bán kính {banKinh}";
        }
    }

    // Lớp Hình chữ nhật
    class HinhChuNhat : Hinh
    {
        private int x2, y2, x3, y3;

        public HinhChuNhat(int x, int y, int x2, int y2, int x3, int y3) : base(x, y)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public override void HienThi()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Hình chữ nhật với các điểm ({x}, {y}), ({x2}, {y2}), ({x3}, {y3})";
        }
    }

    // Lớp Đa tuyến
    class DaTuyen : Hinh
    {
        private List<(int, int)> diem;

        public DaTuyen(int x, int y) : base(x, y)
        {
            diem = new List<(int, int)> { (x, y) };
        }

        public void ThemDiem(int x, int y)
        {
            diem.Add((x, y));
        }

        public override void HienThi()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Đa tuyến với các điểm: {string.Join(", ", diem)}";
        }
    }

    // Kiểm thử các lớp
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DuongThang duong = new DuongThang(0, 0, 5, 5);
            duong.HienThi();

            HinhTron tron = new HinhTron(3, 3, 10);
            tron.HienThi();

            HinhChuNhat hcn = new HinhChuNhat(1, 1, 4, 1, 4, 5);
            hcn.HienThi();

            DaTuyen daTuyen = new DaTuyen(0, 0);
            daTuyen.ThemDiem(2, 2);
            daTuyen.ThemDiem(4, 4);
            daTuyen.HienThi();
        }
    }

}
