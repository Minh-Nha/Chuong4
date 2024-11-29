namespace Chuong4_Bai3;
//CHUONG 4 BT3 : Tính phương trình bậc 1
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai3
{
    static void Main(string[] args)
    {
        //declare variables
        double a, b, x;
        //input
        Console.WriteLine("Nhap a: ");
        double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Nhap b: ");
        double.TryParse(Console.ReadLine(), out b);
        //processing
        if (a != 0)
        {
            x = -b / a;
            Console.WriteLine($"Phuong trinh luon co 1 nghiem duy nhat {x}");
        }
        else if (a == 0 && b == 0)
        {
            Console.WriteLine("Phuong trinh co vo so nghiem");
        }
        else if (a == 0 && b != 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
    }
}
