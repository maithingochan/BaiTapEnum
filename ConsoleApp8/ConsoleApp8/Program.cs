using System;

namespace ConsoleApp8
{
    class Program
    {
        enum GioiTinh
        {
            Nam =0,
            Nu =1
        }
        struct SinhVien
        {
            public string MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemLy;
            public double DiemHoa;
            public int GioiTinh;

            public  SinhVien(String msv106, string name106, double t106, double l106, double h106,int gt106)
            {
                MaSo = msv106;
                HoTen = name106;
                DiemToan = t106;
                DiemLy = l106;
                DiemHoa = h106;
                GioiTinh = gt106;
            }
        }

        static void nhapSV(ref SinhVien x)
        {
            Console.WriteLine("Nhập MSV:");
            x.MaSo = Console.ReadLine();
            Console.WriteLine("Nhập Họ và Tên:");
            x.HoTen = Console.ReadLine();
            Console.WriteLine("Giới tính(nữ  0,nam 1, khác) :");
            x.GioiTinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập Điểm toán:");
            x.DiemToan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập Điểm lý:");
            x.DiemLy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập Điểm hóa:");
            x.DiemHoa = Convert.ToDouble(Console.ReadLine());

        }

        static string  ktgioitinh(SinhVien x)
        {
            //GioiTinh gt = GioiTinh.Nam;
            if ((int)GioiTinh.Nam == 0)
            {
                return "Nam";
            }
            else if ((int)GioiTinh.Nu == 1)
                return "Nữ";
            else
                return "Khác";

        }

        static void xuatSV(SinhVien x)
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Ma SV: {0}", x.MaSo);
            Console.WriteLine("Ho và tên : {0}", x.HoTen);
            Console.WriteLine("Giới Tính: {0}", ktgioitinh(x));
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
                xuatSV(arr[i]);
                
            }
        }
        static double DTB(SinhVien x)
        {
            double DTB = (x.DiemToan + x.DiemLy + x.DiemHoa) / 3;
            DTB = Math.Round(DTB, 2, MidpointRounding.AwayFromZero);
            return DTB;
        }
        static void XapxepHoTenSV(SinhVien[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (String.Compare(arr[i].HoTen, arr[j].HoTen) > 0)
                    {
                        SinhVien t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
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
            XapxepHoTenSV(arr, n);
            XuatMangSV(arr, n);
        }
    }
}

