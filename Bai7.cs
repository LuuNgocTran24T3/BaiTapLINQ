using System;
using System.Collections.Generic;
using System.Linq;

class Bai07
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 2415053122343");
        Console.WriteLine("Ten: Luu Ngoc Tran");
        Console.WriteLine("Lop: 24T3");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        
        bool coSoLonHon10 = numbers.Any(n => n > 10);

        Console.WriteLine("Bài 7: Kiểm tra có số > 10 không");
        Console.WriteLine("Có số > 10 không? " + (coSoLonHon10 ? "Có" : "Không"));
    }
}