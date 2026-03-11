using System;
using System.Collections.Generic;
using System.Linq;

class Bai01
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 2415053122343");
        Console.WriteLine("Ten: Luu Ngoc Tran");
        Console.WriteLine("Lop: 24T3");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        
        var soChan = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Bài 1: Lọc số chẵn");
        Console.WriteLine("Các số chẵn: " + string.Join(", ", soChan));
    }
}
