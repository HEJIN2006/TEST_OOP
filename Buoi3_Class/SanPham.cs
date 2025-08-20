using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Class
{
    internal class SanPham
    {
        private string tensp;
        private int soluong;
        private double dongia;

        public SanPham()
        {
            this.tensp = "No name";
            this.soluong = 0;
            this.dongia = 0;
        }
        public SanPham(string tensp, int sl, double g)
        {
            this.tensp = tensp;
            this.soluong = sl;
            this.dongia = g;
        }

        public string TenSanPham
        {
            get { return tensp; }
            set { tensp = value; }
        }

        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public double DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public static SanPham NhapSanPham()
        {
            Console.OutputEncoding = Encoding.UTF8;
            SanPham p = new SanPham();
            Console.WriteLine("Nhập tên sản phẩm: ");
            p.tensp = Console.ReadLine();
            Console.WriteLine("Nhập số Lượng: ");
            p.soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập đơn giá: ");
            p.dongia = double.Parse(Console.ReadLine());
            return p;
        }
        public void  XuatSanPham()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tên sản phẩm: {tensp}");
            Console.WriteLine($"Số lượng: {soluong}");
            Console.WriteLine($"Đơn giá: {dongia}");
        }
        public static void Nhapdulieulieu(SanPham[] a, int n)
        {
            SanPham[] ds = new SanPham[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin cho phàn tử thứ:  {i + 1}");
                ds[i] = NhapSanPham();
            }
        }
        public static void Xuatdulieulieu(SanPham[] listsp, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"San pham thu {i + 1}");
                listsp[i].XuatSanPham();
            }
        }
    }
}