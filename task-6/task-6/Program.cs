// See https://aka.ms/new-console-template for more information
/*
 
Bir proqram yazın ki, istifadəçidən bir tam ədəd qəbul etsin və bu ədədin rəqəmlərindən neçə dənəsinin tək, 
neçə dənəsinin cüt olduğunu do-while dövrü istifadə edərək hesablasın.(do-while ilə)
Məsələn, istifadəçi 1234 daxil etsə, proqram 1 və 3 tək rəqəmlərdir, 2 və 4 isə cüt rəqəmlərdir, 
nəticədə tək rəqəmlər 2, cüt rəqəmlər isə 2 olacaq.
 
 */

Console.Write("Tam eded daxil edin: ");
string str = Console.ReadLine();

try
{
    int eded = int.Parse(str), tek_say = 0, cut_say = 0;

    do
    {
        int qaliq = eded % 10;
        if (qaliq % 2 == 0) cut_say++;
        else tek_say++;
        eded /= 10;
    }
    while (eded > 0);

    Console.WriteLine($"{str} ededindeki tek reqemlerin sayi: {tek_say} , cut reqemlerin sayi: {cut_say}");

}

catch
{
    Console.WriteLine("Daxil etdiyiniz bir tam eded deyil");
}