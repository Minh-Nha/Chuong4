namespace Chuong4_Bai7;
//CHUONG 4 BT7 : Tính tháng nhập vào thuộc quý nào
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai7
{
    static void Main(string[] args)
    {
        int month;
        Console.WriteLine("Nhap thang");
        int.TryParse(Console.ReadLine(), out month);
        switch (month)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine($"Thang {month} thuoc Quy 1");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine($"Thang {month} thuoc Quy 2");
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine($"Thang {month} thuoc Quy 3");
                break;
            case 10:
            case 11:
            case 12:
                Console.WriteLine($"Thang {month} thuoc Quy 4");
                break;
            default:
                Console.WriteLine("Khong hop le, nhap lai");
                break;

        }
    }
}
