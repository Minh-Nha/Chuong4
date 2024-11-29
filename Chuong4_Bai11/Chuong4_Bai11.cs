namespace Chuong4_Bai11;

internal class Chuong4_Bai11
{
    static void Main(string[] args)
    {
        //declare variables
        int chiSoCu, chiSoMoi;
        int mucDienTieuThu = 0;
        int phanVuotDinhMuc = 0;
        int tienDinhMuc = 0;
        int tienVuotDinhMuc = 0;

        //Input
        Console.WriteLine("Nhap vao chi so moi: ");
        int.TryParse(Console.ReadLine(), out chiSoMoi);
        Console.WriteLine("Nhap vao chi so cu: ");
        int.TryParse(Console.ReadLine(), out chiSoCu);
        

        //processing
        mucDienTieuThu = chiSoMoi - chiSoCu;
        if (mucDienTieuThu <= 50) 
        {
            tienDinhMuc = mucDienTieuThu * 1000;
        }
        else
        {
            tienDinhMuc = 50 * 1000;
            phanVuotDinhMuc = mucDienTieuThu - 50;
            if (phanVuotDinhMuc <= 50)
            {
                tienVuotDinhMuc = phanVuotDinhMuc * 1500; 
            }else if (phanVuotDinhMuc <= 100)
            {
                tienVuotDinhMuc = 50 * 1500 + (phanVuotDinhMuc - 50) * 1800;
            }else
            {
                tienVuotDinhMuc = 50 * 1500 + 50 * 1800 + (phanVuotDinhMuc - 100) * 2500;
            }
        }
        int tongtien = tienDinhMuc + tienVuotDinhMuc;
        //Output
        Console.WriteLine($"Muc dien tieu thu = {mucDienTieuThu}");
        Console.WriteLine($"Tien tra dinh muc = {tienDinhMuc}");
        Console.WriteLine($"Tien tra vuot dinh muc = {tienVuotDinhMuc}");
        Console.WriteLine($"Tong tien = {tongtien}");
    }
}
