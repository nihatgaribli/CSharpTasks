// See https://aka.ms/new-console-template for more information
/*
 
İnteger tipində bir array yaradın və içərisində 10 element olsun.
Array-ın elementlərinə istifadəçidən alınan dəyərləri təyin edin.
Array-ı tərsinə çevirin və nəticəni ekranda göstərin.(Revers methodu istifadə etmədən) 

 */

int[] array = new int[10];

try
{
    Console.Write("Arrayin elementlerini daxil edin: ");
    for (int i = 0; i < 10; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 9; i >= 0; i--)
    {
        Console.Write(array[i] + " ");
    }
}

catch
{
    Console.WriteLine("Massivin elementini sehv daxil edirsiniz");
}

