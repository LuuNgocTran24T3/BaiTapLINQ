using System;
using System.Collections.Generic;
using System.Linq;

class Bai03
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 2415053122343");
        Console.WriteLine("Ten: Luu Ngoc Tran");
        Console.WriteLine("Lop: 24T3");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 3, 4, 5, 2, 6, 7, 8 };
        
        var tangDan = numbers.OrderBy(n => n);

        Console.WriteLine("Bài 3: Sắp xếp tăng dần");
        Console.WriteLine("Tăng dần: " + string.Join(", ", tangDan));
    }
}
