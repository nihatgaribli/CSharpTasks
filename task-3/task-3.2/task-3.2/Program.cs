// See https://aka.ms/new-console-template for more information
/*
 
İstifadəçidən imtahan nəticəsini daxil etməsini tələb edən və
bu nəticəyə görə uyğun kateqoriyayı (əla, yaxşı, orta, zəif) ekrana çap edən bir proqramı yazın.
 
 */

Console.Write("Imtahan neticenizi daxil edin: ");
string input = Console.ReadLine();

//try
//{
//    int netice = int.Parse(input);

//    if (80 < netice && netice <= 100)
//    {
//        Console.WriteLine("Ela");
//    }
//    else if (60 < netice && netice <= 80)
//    {
//        Console.WriteLine("Yaxsi");
//    }
//    else if (40 < netice && netice <= 60)
//    {
//        Console.WriteLine("Orta");
//    }
//    else if (0 <= netice && netice <= 40)
//    {
//        Console.WriteLine("Pis");
//    }
//    else
//    {
//        Console.WriteLine("Daxil etdiyiniz eded her hansi bir imtahan neticesini ifade etmir");
//    }
//}


try
{
    int netice = int.Parse(input);

    switch (netice)
    {
        case int n when (n > 80 && n <= 100):
            Console.WriteLine("Ela");
            break;
        case int n when (n > 60 && n <= 80):
            Console.WriteLine("Yaxsi");
            break;
        case int n when (n > 40 && n <= 60):
            Console.WriteLine("Orta");
            break;
        case int n when (n >= 0 && n <= 40):
            Console.WriteLine("Pis");
            break;
        default:
            Console.WriteLine("Daxil etdiyiniz eded her hansi bir imtahan neticesini ifade etmir");
            break;
    }
}


catch
{
    Console.WriteLine("Sehv ifade daxil etmisiniz");
}


//int netice = int.Parse(input);

//switch (netice)
//{
//    case > 80 and <= 100:
//        Console.WriteLine("Ela");
//        break;
//    case > 60 and <= 80:
//        Console.WriteLine("Yaxsi");
//        break;
//    case > 40 and <= 60:
//        Console.WriteLine("Orta");
//        break;
//    case >= 0 and <= 40:
//        Console.WriteLine("Pis");
//        break;
//    default:
//        Console.WriteLine("Daxil etdiyiniz eded her hansi bir imtahan neticesini ifade etmir");
//        break;
//}
