namespace Chuong4_Bai1;
//CHUONG 4 BT1 : Nhập 4 số nguyên in ra giá trị lớn nhất
//Date 19/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong4_Bai1
{
    static void Main(string[] args)
    {
        //declare variables 
        int max = 0;
        int num1 =0, num2 = 0, num3 = 0, num4 = 0;
        //input
        Console.WriteLine("Nhap vao num1: ");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Nhap vao num2: ");
        int.TryParse(Console.ReadLine(), out num2);
        Console.WriteLine("Nhap vao num3: ");
        int.TryParse(Console.ReadLine(), out num3);
        Console.WriteLine("Nhap vao num4: ");
        int.TryParse(Console.ReadLine(), out num4);
        //processing
        max = num1;
        if (max < num2)
        {
            max = num2;
        }
        if (max < num3) 
        { 
            max = num3;
        }
        if(max < num4)
        {
            max = num4;
        }
        //output
        Console.WriteLine($"So lon nhat: {max}");
    }
}
