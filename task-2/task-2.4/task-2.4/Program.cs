// See https://aka.ms/new-console-template for more information
/*
 
    İstifadəçidən iki ədəd daxil etməsini tələb edin. Bu ədədləri vurun və hasilini konsolda göstərin.
 
 */

Console.Write("Birinci ededi daxil edin: ");
int Input1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci ededi daxil edin: ");
int Input2 = Convert.ToInt32(Console.ReadLine());

int product = Input1 * Input2;

Console.WriteLine("Ededlerin hasili: " + product);