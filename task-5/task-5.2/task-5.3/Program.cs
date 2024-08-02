// See https://aka.ms/new-console-template for more information

/*
 
İnteger tipində bir array yaradın və içərisində 10 element olsun.
Array-ın elementlərinə istifadəçidən alınan dəyərləri təyin edin.
Array-ın elementlərinin ortalamasını hesablayın və ekranda göstərin. 

 */

int[] array = new int[10];
double sum = 0;


try
{
    Console.Write("Arrayin elementlerini daxil edin: ");
    for (int i = 0; i < 10; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
        sum += array[i];
    }

    Console.WriteLine(sum / 10);
}

catch
{
    Console.WriteLine("Massivin elementini sehv daxil edirsiniz");1
}