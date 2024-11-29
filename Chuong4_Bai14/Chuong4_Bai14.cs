namespace Chuong4_Bai14;

internal class Chuong4_Bai14
{
    static void Main(string[] args)
    {
        char player1, player2;
        Console.WriteLine("Nguoi choi 1 nhap vao 'B' = bua, 'K' = keo, 'G' = giay ");
        char.TryParse(Console.ReadLine(), out player1);
        Console.WriteLine("Nguoi choi 2 nhap vao 'B' = bua, 'K' = keo, 'G' = giay ");
        char.TryParse(Console.ReadLine(), out player2);
        switch (player1)
        {
            case 'B':
                switch (player2)
                {
                    case 'B':
                        Console.WriteLine("HOA");
                        break;
                    case 'K':
                        Console.WriteLine("NGUOI CHOI 1 THANG");
                        break;
                    case 'G':
                        Console.WriteLine("NGUOI CHOI 2 THANG");
                        break;
                    default:
                        Console.WriteLine("Vui long nhap 'B' = bua, 'K' = keo, 'G' = giay");
                        break;
                }
                break;
            case 'K':
                switch (player2)
                {
                    case 'B':
                        Console.WriteLine("NGUOI CHOI 2 THANG");
                        break;
                    case 'K':
                        Console.WriteLine("HOA");
                        break;
                    case 'G':
                        Console.WriteLine("NGUOI CHOI 1 THANG");
                        break;
                    default:
                        Console.WriteLine("Vui long nhap 'B' = bua, 'K' = keo, 'G' = giay");
                        break;
                }
                break;
            case 'G':
                switch (player2)
                {
                    case 'B':
                        Console.WriteLine("NGUOI CHOI 1 THANG");
                        break;
                    case 'K':
                        Console.WriteLine("NGUOI CHOI 2 THANG");
                        break;
                    case 'G':
                        Console.WriteLine("HOA");
                        break;
                    default:
                        Console.WriteLine("Vui long nhap 'B' = bua, 'K' = keo, 'G' = giay");
                        break;
                }
                break;
            default:
                Console.WriteLine("Vui long nhap 'B' = bua, 'K' = keo, 'G' = giay");
                break;
        }
    }
}
