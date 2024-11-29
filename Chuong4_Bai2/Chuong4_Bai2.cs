namespace Chuong4_Bai2;
//CHUONG 4 BT2 : Tính điểm trung bình
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai2
{
    static void Main(string[] args)
    {
        //declare variables
        double averageScore = 0;
        //input
        do
        {
            Console.WriteLine("Nhap diem trung binh: ");
            double.TryParse(Console.ReadLine(), out averageScore);
            if (averageScore < 0 || averageScore > 10)
            {
                Console.WriteLine("Vui long nhap diem dung theo yeu cau");
            }
        }
        while (averageScore < 0 || averageScore > 10);
        //processing, output
        if (averageScore < 3)
        {
            Console.WriteLine("Xep loai kem");
        }
        else if (averageScore < 5)
        {
            Console.WriteLine("Xep loai yeu");
        }
        else if (averageScore < 6.5)
        {
            Console.WriteLine("Xep loai trung binh kha");
        }
        else if (averageScore < 8)
        {
            Console.WriteLine("Xep loai kha");
        }
        else if (averageScore < 9)
        {
            Console.WriteLine("Xep loai gioi");
        }
        else
        {
            Console.WriteLine("Xep loai xuat sac");
        }

    }
}
