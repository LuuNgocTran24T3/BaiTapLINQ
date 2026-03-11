using System;
using System.Collections.Generic;
using System.Linq;

class Bai15
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 2415053122343");
        Console.WriteLine("Ten: Luu Ngoc Tran");
        Console.WriteLine("Lop: 24T3");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> duTrung = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        var distinct = duTrung.Distinct();

        Console.WriteLine("Bài 15: Loại bỏ phần tử trùng");
        Console.WriteLine("Sau khi loại trùng: " + string.Join(", ", distinct));
    }
}