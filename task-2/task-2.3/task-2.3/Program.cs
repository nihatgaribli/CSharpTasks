// See https://aka.ms/new-console-template for more information
/*  
 
İki tam ədəd daxil etməsini tələb edin. Daxil edilən ədədlərin fərqini (birindən digərinə) hesablayın və nəticəni konsolda göstərin
 
 */



Console.Write("Birinci ededi daxil edin: ");
int Input1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci ededi daxil edin: ");
int Input2 = Convert.ToInt32(Console.ReadLine());

int difference = Input1 - Input2;

Console.WriteLine("Ededlerin ferqi: " + difference);

