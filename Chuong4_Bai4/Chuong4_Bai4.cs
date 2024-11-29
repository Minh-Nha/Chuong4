namespace Chuong4_Bai4;
//CHUONG 4 BT4 : Tính số chẵn chia hết cho 3
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai4
{
    static void Main(string[] args)
    {
        //declare variables
        int num;
        //input
        do
        {
            Console.WriteLine("Nhap 1 so tu 1 den 100");
            int.TryParse(Console.ReadLine(), out num);
            if (num < 1 || num > 100)
            {
                Console.WriteLine("Vui long nhap lai");
            }
        }
        while (num < 1 || num > 100);
        //processing, output
        if (num % 2 == 0 && num % 3 == 0)
        {
            Console.WriteLine($"So vua nhap {num} la so chan chia het cho 3");
        }else
        {
            Console.WriteLine("Khong thoa dieu kien");
        }
    }
}
