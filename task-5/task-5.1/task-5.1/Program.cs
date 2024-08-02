// See https://aka.ms/new-console-template for more information
/*
 
İnteger tipində bir array yaradın və içərisində 10 element olsun.
Array-ın hər bir elementinə istifadəçidən alınan dəyərləri təyin edin.
Array-ın elementlərini ekranda göstərin.
 
 */



#region Array

int[] array = new int[10];
try
{
    Console.Write("Arrayin elementlerini daxil edin: ");
    for (int i = 0; i < 10; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < 10; i++)
    {
        Console.Write(array[i] + " ");
    }
}

catch
{
    Console.WriteLine("Arrayin elementini sehv daxil edirsiniz");
}
#endregion