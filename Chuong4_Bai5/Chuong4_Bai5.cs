namespace Chuong4_Bai5;
//CHUONG 4 BT5 : Đổi giờ phút giây
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai5
{
    static void Main(string[] args)
    {
        //declare variable
        double hour = 0, minute = 0, second = 0, addSecond = 0, totalSecond = 0;
        double newHour = 0, newMinute = 0, newSecond = 0;
        //input
        Console.WriteLine("nhap gio: ");
        double.TryParse(Console.ReadLine(), out hour);
        Console.WriteLine("nhap phut: ");
        double.TryParse(Console.ReadLine(), out minute);
        Console.WriteLine("nhap giay: ");
        double.TryParse(Console.ReadLine(), out second);
        Console.WriteLine("nhap giay them: ");
        double.TryParse(Console.ReadLine(), out addSecond);
        //processing
        totalSecond = hour * 3600 + minute * 60 + second + addSecond; //đổi toàn bộ ra giây
        newHour = (totalSecond / 3600) % 24;
        newMinute = (totalSecond / 60) % 60;
        newSecond = totalSecond % 60;
        //output
        Console.WriteLine($"Chuyen thoi gian nhap vao {hour}:{minute}:{second} va so giay them {addSecond} thanh {newHour}:{newMinute}:{newSecond}");


    }
}
