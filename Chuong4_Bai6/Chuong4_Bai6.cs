namespace Chuong4_Bai6;
//CHUONG 4 BT6 : Tính điểm ba môn Toán, Lý, Hoá
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai6
{
    static void Main(string[] args)
    {
        //declare variables
        double math, physics, chemistry;
        double sum;
        //input
        Console.WriteLine("Nhap diem mon toan: ");
        double.TryParse(Console.ReadLine(), out math);
        Console.WriteLine("Nhap diem mon ly: ");
        double.TryParse(Console.ReadLine(), out physics);
        Console.WriteLine("Nhap diem mon hoa: ");
        double.TryParse(Console.ReadLine(), out chemistry);
        //processing, output
        sum = math + physics + chemistry;
        if (sum >= 15 && math >= 4 && physics >= 4 && chemistry >= 4)
        {
            Console.WriteLine("Dau");
            if (math > 5 && math > 5 && physics > 5)
            {
                Console.WriteLine("Hoc Deu Cac Mon");
            }
            else
            {
                Console.WriteLine("Hoc Chua Deu Cac Mon");
            }
        }
        else
        {
            Console.WriteLine("Thi Hong");
        }
    }
}
