using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id {get;set;}
    public string Name {get;set;}
    public double Score {get;set;}
}

class Bai17
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

        double trungBinh = students.Average(s => s.Score);

        Console.WriteLine("Bài 17: Điểm trung bình sinh viên");
        Console.WriteLine("Điểm trung bình: " + trungBinh);
    }
}