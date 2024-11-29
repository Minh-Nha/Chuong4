namespace Chuong4_Bai13;

internal class Chuong4_Bai13
{
    static void Main(string[] args)
    {
        int month, year;
        Console.WriteLine("Nhap thang");
        int.TryParse(Console.ReadLine(), out month);
        Console.WriteLine("Nhap nam");
        int.TryParse(Console.ReadLine(), out year);
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine($"Thang {month} co 31 ngay");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine($"Thang {month} co 30 ngay");
                break;
            case 2:
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) 
                {
                    Console.WriteLine($"Thang {month} co 29 ngay vi nam {year} la nam nhuan");
                }
                else
                {
                    Console.WriteLine($"Thang {month} co 28 ngay");
                }
                break;
            default:
                Console.WriteLine("Khong hop le, nhap lai");
                break;
        }
    }
}
