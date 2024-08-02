// See https://aka.ms/new-console-template for more information
/*
 
İstifadəçidən bir tam ədəd daxil etməsini tələb edən və bu ədədin müsbət, mənfi və ya sıfır olduğunu yoxlayan bir  proqramı yazın.
 
 */

Console.Write("Tam ededi daxil edin: ");
string input = Console.ReadLine();

//try
//{
//    int eded = int.Parse(input);

//    if( eded > 0)
//    {
//        Console.WriteLine("Daxil etdiyiniz eded musbetdir");
//    }
//    else if ( eded < 0 )
//    {
//        Console.WriteLine("Daxil etdiyiniz eded menfidir");
//    }
//    else 
//    {
//        Console.WriteLine("Daxil etdiyiniz eded sifirdir");
//    }
//}

try
{
    int eded = int.Parse(input);

    switch (eded)
    {
        case int n when ( n > 0 ):
            Console.WriteLine("Daxil etdiyiniz eded musbetdir");
            break;
        case int n when ( n < 0 ):
            Console.WriteLine("Daxil etdiyiniz eded menfidir");
            break;
       default:
            Console.WriteLine("Daxil etdiyiniz eded sifirdir");
            break;
    }
}


catch
{
    Console.WriteLine("Yanlis input daxil edirsiniz");
}