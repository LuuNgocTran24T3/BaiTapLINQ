using System;
using System.Collections.Generic;
using System.Linq;

class SinhVien
{
    public string Ten { get; set; }
    public int Tuoi { get; set; }
    public string Khoa { get; set; }
    public double DiemTB { get; set; }
    public int NamHoc { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 2415053122343");
        Console.WriteLine("Ten: Luu Ngoc Tran");
        Console.WriteLine("Lop: 24T3");
        Random rd = new Random();
        List<string> dsKhoa = new List<string>()
        {
            "Công nghệ số",
            "Điện - Điện tử",
            "Công nghệ hóa học môi trường",
            "Sư phạm công nghiệp",
            "Xây dựng",
            "Cơ khí"
        };

        List<SinhVien> dsSV = new List<SinhVien>();

        for (int i = 1; i <= 20; i++)
        {
            dsSV.Add(new SinhVien
            {
                Ten = "SV" + i,
                Tuoi = rd.Next(18, 25),
                Khoa = dsKhoa[rd.Next(dsKhoa.Count)],
                DiemTB = Math.Round(rd.NextDouble() * 10, 2),
                NamHoc = rd.Next(1, 5)
            });
        }

        Console.WriteLine("Danh sach sinh vien:");
        foreach (var sv in dsSV)
        {
            Console.WriteLine($"{sv.Ten} | Tuoi: {sv.Tuoi} | Khoa: {sv.Khoa} | DiemTB: {sv.DiemTB} | NamHoc: {sv.NamHoc}");
        }
        Console.WriteLine("\n---------------------------");

        // 1. Max tuổi và Min tuổi
        int maxTuoi = dsSV.Max(sv => sv.Tuoi);
        int minTuoi = dsSV.Min(sv => sv.Tuoi);
        Console.WriteLine("Max tuoi: " + maxTuoi);
        Console.WriteLine("Min tuoi: " + minTuoi);
        Console.WriteLine("\n---------------------------");

        // 2. Kiểm tra có SV thuộc khoa Công nghệ số
        bool coSV = dsSV.Any(sv => sv.Khoa == "Công nghệ số");
        if (coSV)
            Console.WriteLine("Co sinh vien thuoc khoa Cong nghe so");
        else
            Console.WriteLine("Khong co sinh vien thuoc khoa Cong nghe so");
        Console.WriteLine("\n---------------------------");

        // 3. Lấy 10 SV có điểm trung bình cao nhất khoa Công nghệ số
        var top10 = dsSV
            .Where(sv => sv.Khoa == "Công nghệ số")
            .OrderByDescending(sv => sv.DiemTB)
            .Take(10);
        Console.WriteLine("Top 10 sinh vien diem cao nhat khoa Cong nghe so:");
        foreach (var sv in top10)
        {
            Console.WriteLine($"{sv.Ten} - DiemTB: {sv.DiemTB}");
        }
        Console.WriteLine("\n---------------------------");

        // 4. Bỏ qua sinh viên năm cuối
        var dsConLai = dsSV.Where(sv => sv.NamHoc != 4).ToList();
        Console.WriteLine("Danh sach sinh vien khong phai nam cuoi:");
        foreach (var sv in dsConLai)
        {
            Console.WriteLine($"{sv.Ten} | Nam hoc: {sv.NamHoc}");
        }
        Console.ReadKey();
    }
}