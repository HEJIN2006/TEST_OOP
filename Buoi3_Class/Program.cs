using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Class
{

    // Tên hàng                  Gạo Ngô Khoa
    // Số lượng(tấn)              100	90	20
    // Đơn giá(nghìn đồng/1kg)    30	15	12
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //SanPham sp1 = new SanPham();
            //sp1.XuatSanPham();
            //Console.WriteLine($"tên sản phẩm: {sp1.TenSanPham}");
            //Console.WriteLine($"số lượng: {sp1.SoLuong}");
            //Console.WriteLine($"đơn giá: {sp1.DonGia}");
            //sp1.TenSanPham = "Đường";
            //sp1.SoLuong = 20;
            //sp1.DonGia = 30000;
            //sp1.XuatSanPham();
            //Console.WriteLine($"Tên sản phẩm: {sp1.TenSanPham}");
            //Console.WriteLine($"Số lượng: {sp1.SoLuong}");
            //Console.WriteLine($"Đơn giá: {sp1.DonGia}");
            //SanPham sp2 = new SanPham("Mía", 25, 10000);
            //sp2.XuatSanPham();
            //Console.WriteLine($"Tên sản phẩm: {sp2.TenSanPham}");
            //Console.WriteLine($"Số lượng: {sp2.SoLuong}");
            //Console.WriteLine($"Đơn giá: {sp2.DonGia}");
            //SanPham sp3 = new SanPham();
            //sp3.NhapSanPham()
            //sp3.XuatSanPham();
            //SanPham.NhapSanPham().XuatSanPham();
            //SanPham sp3 = SanPham.NhapSanPham();
            //sp3.XuatSanPham();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = 3;
            SanPham[] l = new SanPham[n];
            SanPham.Nhapdulieulieu(l,n);
            SanPham.Xuatdulieulieu(l,n);
        }
    }
}
