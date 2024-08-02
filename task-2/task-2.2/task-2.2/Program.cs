// See https://aka.ms/new-console-template for more information
/*
 
 İstifadəçidən iki tam ədəd daxil etməsini istəyin. Daxil edilən ədədlərin cəmini hesablayın və nəticəni konsolda göstərin.

 */


 Console.Write("Birinci ededi daxil edin: ");
int Input1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci ededi daxil edin: ");
int Input2 = Convert.ToInt32(Console.ReadLine());

int sum = Input1 + Input2;

Console.WriteLine("Ededlerin cemi: " + sum);
