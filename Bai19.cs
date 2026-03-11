using System;
using System.Collections.Generic;
using System.Linq;

class Bai19
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 2415053122343");
        Console.WriteLine("Ten: Luu Ngoc Tran");
        Console.WriteLine("Lop: 24T3");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<int> dsXuatHien = new List<int> { 1, 2, 2, 3, 3, 3, 4 };

        int soNhieuNhat = dsXuatHien
            .GroupBy(n => n)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;

        Console.WriteLine("Bài 19: Số xuất hiện nhiều nhất");
        Console.WriteLine("Số xuất hiện nhiều nhất: " + soNhieuNhat);
    }
}