// See https://aka.ms/new-console-template for more information
/*
 
 İnteger tipində bir array yaradın və içərisində 10 element olsun.
Array-ın elementlərinə istifadəçidən alınan dəyərləri təyin edin.
Array-ın elementlərinin ortalamasını hesablayın və ekranda göstərin.
 
 */


using task_5._3;

Arrays arrays = new Arrays(10);
arrays.InputArray();
Console.WriteLine("Arrayin elementlerinin ortalamasi: " + arrays.AverageArray());