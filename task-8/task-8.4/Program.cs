// See https://aka.ms/new-console-template for more information
/*
 
Bir neçə tam ədəd daxil edin və onları bir HashSet-ə əlavə edin.
İkinci bir neçə tam ədəd daxil edin və onları başqa bir HashSet-ə əlavə edin.
Hər iki HashSet-də olan unikal elementləri tapın və ekrana çap edin.(HashSetin methodundan istifad' etməklə)
 
 */
 
HashSet<int> Set1 = new HashSet<int> { 1, 2, 3, 4, 5, 6 };
HashSet<int> Set2 = new HashSet<int> { 2, 4, 6, 8, 10 };

Set1.IntersectWith(Set2); // bu metod her iki hashsetde olan unikal elementleri tapir

foreach (int i in Set1)
{
    Console.Write(i + " ");
}