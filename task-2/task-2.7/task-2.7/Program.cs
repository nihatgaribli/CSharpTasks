// See https://aka.ms/new-console-template for more information
/*
 
İstifadəçidən iki  ədəd daxil etməsini istəyin(biri int tipində olsun , biri string tipində). 
Daxil edilən ədədlərin cəmini hesablayın və nəticəni konsolda göstərin.
 
 */

Console.Write("Birinci ededi daxil edin: ");
int intInput = Convert.ToInt32(Console.ReadLine());

Console.Write("Ikinci ededi daxil edin: ");
string strInput = Console.ReadLine();

int.TryParse(strInput, out int intInput1);

int sum = intInput + intInput1;
Console.WriteLine("Ededlerin cemi: " + sum);
