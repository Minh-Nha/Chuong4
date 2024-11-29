namespace Chuong4_Bai9;
//CHUONG 4 BT9 : Nhập 2 số thực và chọn 1 trong 4 toán tử +,-,*,/
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai9
{
    static void Main(string[] args)
    {
        float x = 0, y = 0;
        char operat;
        Console.WriteLine("Nhap x");
        float.TryParse(Console.ReadLine(), out x);
        Console.WriteLine("Nhap y");
        float.TryParse(Console.ReadLine(), out y);
        Console.WriteLine("Nhap toan tu +,-,*,/");
        char.TryParse(Console.ReadLine(), out operat);
        switch (operat)
        {
            case '+':
                Console.WriteLine($"{x} + {y} = {x + y}");
                break;
            case '-':
                Console.WriteLine($"{x} - {y} = {x - y}");
                break;
            case '*':
                Console.WriteLine($"{x} * {y} = {x * y}");
                break;
            case '/':
                if(y == 0)
                {
                    Console.WriteLine("Khong the chia do y = 0");
                }
                else
                {
                    Console.WriteLine($"{x} / {y} = {x / y}");
                }
                break;
            default:
                Console.WriteLine("Nhap sai toan tu vui long nhap lai");
                break;
        }
    }
}
