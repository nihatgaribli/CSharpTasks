// See https://aka.ms/new-console-template for more information
/*
 
Bir proqram yazın ki, istifadəçidən bir tam ədəd qəbul etsin və bu ədədin rəqəmlərinin cəmini while dövrü istifadə edərək hesablasın. 
Məsələn, istifadəçi 1234 daxil etsə, proqram 1 + 2 + 3 + 4 = 10 hesablamalıdır.(do-while ilə)
 
 */


Console.Write("Tam eded daxil edin: ");
string input = Console.ReadLine();

try
{
    int eded = int.Parse(input);
    int sum = 0;

    Console.Write($"{eded} ededinin reqemleri cemi: ");

    do
    {
        sum += eded % 10;
        eded /= 10;
    } while (eded > 0);

    Console.WriteLine($"{sum}");
}

catch
{
    Console.WriteLine("Yanlis input daxil etmisiniz");
}