// See https://aka.ms/new-console-template for more information
/*
 
Bir proqram yazın ki, istifadəçinin daxil etdiyi  rəqəmin faktorialını hesablasın.(while ilə) 

 */

Console.Write("Tam eded daxil edin: ");
string input  = Console.ReadLine();

try
{
    int eded = int.Parse(input);
    Console.Write($"{eded}!=");   
    int factorial = 1;
    while(eded > 0)
    {
        factorial *= eded;
        eded--;
    }
    Console.Write($"{factorial} ");
}

catch 
{
    Console.WriteLine("Yanlis input daxil etmisiniz");
}