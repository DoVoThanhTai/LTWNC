using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    using System;
    using System.Collections.Generic;

    // Lớp cơ sở trừu tượng Động vật
    abstract class DongVat
    {
        protected string Loai;

        public DongVat(string loai)
        {
            this.Loai = loai;
        }

        public abstract string PhatTieng();
        public abstract string ThongTin();
    }

    // Lớp Chó
    class Cho : DongVat
    {
        public string Ten { get; set; }
        public string Giong { get; set; }

        public Cho(string ten, string giong) : base("Động vật có vú")
        {
            this.Ten = ten;
            this.Giong = giong;
        }

        public override string PhatTieng()
        {
            return "Gâu gâu";
        }

        public override string ThongTin()
        {
            return $"Chó {Ten}, Giống: {Giong}, Loài: {Loai}";
        }
    }

    // Lớp Mèo
    class Meo : DongVat
    {
        public string Ten { get; set; }

        public Meo(string ten) : base("Động vật có vú")
        {
            this.Ten = ten;
        }

        public override string PhatTieng()
        {
            return "Meo meo";
        }

        public void Leo(string noi)
        {
            Console.WriteLine($"Mèo {Ten} đang leo lên {noi}");
        }

        public override string ThongTin()
        {
            return $"Mèo {Ten}, Loài: {Loai}";
        }
    }

    // Lớp Vịt
    class Vit : DongVat
    {
        public string Ten { get; set; }

        public Vit(string ten) : base("Chim")
        {
            this.Ten = ten;
        }

        public override string PhatTieng()
        {
            return "Quác quác";
        }

        public void Boi(string noi)
        {
            Console.WriteLine($"Vịt {Ten} đang bơi trong {noi}");
        }

        public override string ThongTin()
        {
            return $"Vịt {Ten}, Loài: {Loai}";
        }
    }

    // Kiểm thử các lớp
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cho cho = new Cho("Lu", "Chó cỏ");
            Console.WriteLine(cho.ThongTin());
            Console.WriteLine($"Tiếng kêu: {cho.PhatTieng()}");

            Meo meo = new Meo("Mướp");
            Console.WriteLine(meo.ThongTin());
            Console.WriteLine($"Tiếng kêu: {meo.PhatTieng()}");
            meo.Leo("cây");

            Vit vit = new Vit("Cỏ");
            Console.WriteLine(vit.ThongTin());
            Console.WriteLine($"Tiếng kêu: {vit.PhatTieng()}");
            vit.Boi("hồ");
        }
    }

}
