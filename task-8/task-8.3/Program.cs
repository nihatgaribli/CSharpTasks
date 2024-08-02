// See https://aka.ms/new-console-template for more information
 /*

 Bir Dictionary yaradın, burada açar məhsulun adı, dəyər isə məhsulun qiyməti olacaq.
 Bir neçə məhsulun adını və qiymətini Dictionary-yə əlavə edin.
 İstifadəçidən məhsul adı soruşun və həmin məhsulun qiymətini ekrana çap edin. 
 Əgər məhsul Dictionary-də yoxdursa, "Məhsul tapılmadı" mesajını verin.

  */

Dictionary<string, int> Product = new Dictionary<string, int>();
Product.Add("arduino", 100);
Product.Add("keyboard", 80);
Product.Add("mouse", 50);
Product.Add("ram", 250);
Product.Add("ssd", 200);

Console.Write("Mehsulun adini daxil edin: ");

string input = Console.ReadLine().ToLower();
bool t = false;

foreach(var item in Product)
{
    if(item.Key == input) 
    {
        Console.Write(item.Value);
        t = true;
        break;
    }
}
if(t == false)
{
    Console.WriteLine("Mehsul tapilmadi.");
}