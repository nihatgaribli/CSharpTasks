// See https://aka.ms/new-console-template for more information
/* 
    Proqram istifadəçidən məlumat daxil etməsini tələb edir. Daxil edilən məlumatın data tipini müəyyən edin(məsələn tam ədəd, 
    onluq ədəd, string). Daxil edilən məlumatı uyğun data tipinə çevirin və fərqli əməliyyatlar aparan proqram nümunəsi təqdim edin.
    Məsələn: Tam ədədlər üzərində riyazi əməliyyatlar(toplama, çıxma), onluq ədədlər üzərində əməliyyatlar(vurma, bölmə).
 */

/*
Console.Write("Melumatı daxil edin: ");
string str = Console.ReadLine();

if (int.TryParse(str, out int tam)) 
{
    // Tam ədəd üzərində əməliyyatlar
    Console.WriteLine("Daxil edilen melumat tam ededdir.");
    Console.WriteLine($"Tam ededi 1 vahid artıraq: {tam + 1}"); 
    Console.WriteLine($"Tam ededi 1 vahid azaldaq: {tam - 1}"); 
}
else if (double.TryParse(str, out double onluq)) 
{
    // Onluq ədəd üzərində əməliyyatlar
    Console.WriteLine("Daxil edilen melumat onluq ededdir.");
    Console.WriteLine($"Onluq ededi 2-e vurmaq: {onluq * 2}");
    Console.WriteLine($"Onluq ededi 2-e bölmek: {onluq / 2}");
}
else
{
    // String üzərində əməliyyatlar
    Console.WriteLine("Daxil edilen melumat stringdir."); 
    Console.WriteLine($"Stringin uzunluğu: {str.Length}");
    Console.WriteLine($"Stringi boyuk herflerle yazmaq: {str.ToUpper()}");
}*/




Console.Write("Melumatı daxil edin: ");
string input = Console.ReadLine();

Type type = input.GetType();

Console.WriteLine($"inputun tipi: {type.Name}");