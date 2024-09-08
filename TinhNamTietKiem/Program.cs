using System;
using System.Collections.Generic;
using System.Text;
//họ tên: Nguyễn Hữu Thắng
//bắt đầu làm bài toán: Tính số năm cần gửi tiết kiệm
namespace TinhNamTietKiem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float s, t, p;
            int n = 0;

            Console.WriteLine("NHap so tien dang co: ");
            s = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tien muon co: ");
            t = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap lai suat % nam: ");
            p = float.Parse(Console.ReadLine());

            //Tinh toan
            while (s<t)
            {
                s += s * (0.01f * p);
                n++;
            }
            Console.WriteLine("So nam can gui tiet kiem = {0}", n);
            Console.ReadKey();
        }
    }
}
