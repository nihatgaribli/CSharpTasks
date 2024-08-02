// See https://aka.ms/new-console-template for more information
/*
 
Bir integer List yaradın və onu 10 fərqli dəyərlə doldurun. 
Bu List-in elementlərini konsola çap edin, müəyyən bir elementi silin və yenidən çap edin.
 
 */

List<int> Digits = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.Write("Ilk list: ");
foreach(int digit in Digits)
{
    Console.Write(digit + " ");
}

// Digits.RemoveAt(5); // 5ci indexdeki elementi silir
// Digits.RemoveAll(digit => digit > 2); // 2den boyuk butun elementleri silir
// Digits.RemoveRange(3, 6); // 3 den sonra 6 dene elementi silir

Digits.Remove(5); // 5 elementini silir

Console.Write("\nElement silinen list: ");
foreach (int digit in Digits)
{
    Console.Write(digit + " ");
}