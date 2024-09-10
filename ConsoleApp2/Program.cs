using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float s, t, p;
            int n = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Phần mềm tính số tháng cần gửi tiết kiệm");
            Console.Write("NHap so tien dang co: ");
            s = float.Parse(Console.ReadLine());
            Console.Write("Nhap so tien muon co: ");
            t = float.Parse(Console.ReadLine());
            Console.Write("Nhap lai suat % nam: ");
            p = float.Parse(Console.ReadLine());

            //Tinh toan
            
        }

        static bool XuLy (float s, float t, float p, ref int n)
        {
            while (s < t)
            {
                s += s * (0.01f * p);
                n++;
                return true;
            }
        }
    }
}
