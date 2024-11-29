namespace Chuong4_Bai12;
//CHUONG 4 BT12 : Kiem tra ky tu nhap vao thuoc tap hop nao
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai12
{
    static void Main(string[] args)
    {
        char character;
        Console.WriteLine("Nhap vao 1 ky tu");
        char.TryParse(Console.ReadLine(), out character);
        if (character >= 'a' && character <= 'z')
        {
            Console.WriteLine($"{character} thuoc tap hop 'a' - 'z'");
        }
        else if (character >= 'A' && character <= 'Z')
        {
            Console.WriteLine($"{character} thuoc tap hop 'A' - 'Z'");
        }
        else if (character >= '0' && character <= '9')
        {
            Console.WriteLine($"{character} thuoc tap hop '0' - '9'");
        }else
        {
            Console.WriteLine($"{character} thuoc tap hop khac");
        }
    }
}
