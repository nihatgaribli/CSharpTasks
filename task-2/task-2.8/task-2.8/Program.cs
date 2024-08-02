// See https://aka.ms/new-console-template for more information
/*
 
İstifadəçidən string tipində ədəd daxil etməsini tələb edin. Daxil edilən ədədi int tipinə çevirin. 
Əgər int tipinə çevirilirsə çevirsin, çevirmək mümkün deyilsə istifadəçiyə message qaytarsın
 
 */


Console.Write("Ededi daxil edin: ");
string str = Console.ReadLine();

if( int.TryParse(str , out int eded) )
{
    Console.WriteLine("Tam eded: " +  eded);
}

else
{
    Console.WriteLine("Daxil etdiyiniz eded tam eded deyil");
}