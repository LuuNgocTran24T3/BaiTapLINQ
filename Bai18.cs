using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id {get;set;}
    public string Name {get;set;}
    public double Score {get;set;}
}

class Bai18
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 2415053122343");
        Console.WriteLine("Ten: Luu Ngoc Tran");
        Console.WriteLine("Lop: 24T3");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<Student> students = new List<Student>()
        {
            new Student { Id=1, Name="An",   Score=8 },
            new Student { Id=2, Name="Binh", Score=6 },
            new Student { Id=3, Name="Chi",  Score=9 },
            new Student { Id=4, Name="Dung", Score=7 }
        };

        var nhom = students.GroupBy(s =>
        {
            if (s.Score >= 8) return "Giỏi";
            else if (s.Score >= 6) return "Khá";
            else return "Trung bình";
        });

        Console.WriteLine("Bài 18: Nhóm sinh viên theo xếp loại");
        foreach (var group in nhom)
            Console.WriteLine($"  [{group.Key}]: " + string.Join(", ", group.Select(s => s.Name)));
    }
}