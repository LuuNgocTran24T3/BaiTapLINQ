class Student
{
    public int Id {get;set;}
    public string Name {get;set;}
    public double Score {get;set;}
}

class Bai10
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
        
        var svTheoDiem = students.OrderByDescending(s => s.Score);

        Console.WriteLine("Bài 10: Sắp xếp theo điểm giảm dần");
        foreach (var s in svTheoDiem)
            Console.WriteLine($"  {s.Name} - {s.Score}");
    }
}