namespace Chuong4_Bai8;
//CHUONG 4 BT8 : Xác định biến ký tự color rồi in ra thông báo
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai8
{
    static void Main(string[] args)
    {
        char color;
        Console.WriteLine("nhap ki tu: ");
        char.TryParse(Console.ReadLine(), out color);
        switch (color)
        {
            case 'R':
            case 'r':
                Console.WriteLine("RED");
                break;
            case 'G':
            case 'g':
                Console.WriteLine("GREEN");
                break;
            case 'B':
            case 'b':
                Console.WriteLine("BLUE");
                break;
            default:
                Console.WriteLine("BLACK");
                break;
        }

    }
}
