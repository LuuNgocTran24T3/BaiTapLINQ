using System;
using System.Collections.Generic;
using System.Linq;

class Bai04
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 2415053122343");
        Console.WriteLine("Ten: Luu Ngoc Tran");
        Console.WriteLine("Lop: 24T3");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        
        var giamDan = numbers.OrderByDescending(n => n);

        Console.WriteLine("Bài 4: Sắp xếp giảm dần");
        Console.WriteLine("Giảm dần: " + string.Join(", ", giamDan));
    }
}