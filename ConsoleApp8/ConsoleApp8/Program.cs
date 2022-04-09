using System;

namespace ConsoleApp8
{
    class Program
    {
        enum HocLuc
        {
            Tốt,
            Khá,
            Trung_Bình,
            Yếu
        }
        struct SinhVien
        {
            public string MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemLy;
            public double DiemHoa;

            public  SinhVien(String msv, string name, double t, double l, double h)
            {
                MaSo = msv;
                HoTen = name;
                DiemToan = t;
                DiemLy = l;
                DiemHoa = h;
                
            }
        }

        static void nhapSV(ref SinhVien x)
        {
            Console.WriteLine("Nhập MSV:");
            x.MaSo = Console.ReadLine();
            Console.WriteLine("Nhập Họ và Tên:");
            x.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập Điểm toán:");
            x.DiemToan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập Điểm lý:");
            x.DiemLy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập Điểm hóa:");
            x.DiemHoa = Convert.ToDouble(Console.ReadLine());

        }

        static void xuatSV(SinhVien x)
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Ma SV: {0}", x.MaSo);
            Console.WriteLine("Ho và tên : {0}", x.HoTen);
            Console.WriteLine("Điểm toán: {0}", x.DiemToan);
            Console.WriteLine("Điểm lý: {0}", x.DiemLy);
            Console.WriteLine("Điểm hóa: {0}", x.DiemHoa);
            Console.WriteLine("Điểm trung binh: {0}", DTB(x));
        }
        static void NhapMangSV(SinhVien[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                // cách 2 nhập trực tiếp vào vùng nhớ cửa mảng 
                nhapSV(ref arr[i]);

            }
        }
        static void XuatMangSV(SinhVien[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                // cách 2 nhập trực tiếp vào vùng nhớ cửa mảng 
                Console.WriteLine("***************************");
                xuatSV(arr[i]);

            }
        }
        static double DTB(SinhVien x)
        {
            double DTB = (x.DiemToan + x.DiemLy + x.DiemHoa) / 3;
            DTB = Math.Round(DTB, 2, MidpointRounding.AwayFromZero);
            return DTB;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = int.Parse(Console.ReadLine());
            SinhVien[] arr = new SinhVien[n];
            //string msv;
            //string name;
            //double t;
            //double l;
            //double h;
            NhapMangSV(arr,n);
            XuatMangSV(arr, n);
        }
    }
}

