// See https://aka.ms/new-console-template for more information
/*
 
İstifadəçidən iki tam ədəd daxil etməsini tələb edin. Daxil edilən ədədləri bir-birinə bölün və qalıq hissəni konsolda göstərin. 
Qeyd: Bölünən ədədin 0-a bölünməsinə nəzərə alın.

 */



Console.Write("Birinci ededi daxil edin: ");
int Input1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ikinci ededi daxil edin: ");
int Input2 = Convert.ToInt32(Console.ReadLine());

if (Input2 == 0)
{
    Console.WriteLine("0-a bolme emeliyyati mumkun deyil");
}

else
{
    int result = Input1 % Input2;
    Console.WriteLine("Ededlerin nisbetinden alinan qaliq: " + result);
}