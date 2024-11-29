namespace Chuong4_Bai10;
//CHUONG 4 BT10 : Tinh phuong trinh bac 2
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai10
{
    static void Main(string[] args)
    {
        double a = 0, b = 0 ,c = 0;
        double x1 = 0, x2 = 0;
        double delta = 0;
        do
        {
            Console.WriteLine("Nhap vao a: ");
            double.TryParse(Console.ReadLine(), out a);
            if (a == 0)
            {
                Console.WriteLine("vui long nhap a khac 0");
            }
        }
        while (a == 0);
        Console.WriteLine("Nhap vao b: ");
        double.TryParse(Console.ReadLine(), out b);
        Console.WriteLine("Nhap vao c: ");
        double.TryParse(Console.ReadLine(), out c);
     
        // delta
        delta = b * b - 4 * a * c;
        //Console.WriteLine($"Delta = {delta}");
        if (delta > 0)
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Phuong trinh co 2 nghiem phan biet: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Phuong trinh co nghiem kep: x = {x}");
        }
        else
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
    }
}
