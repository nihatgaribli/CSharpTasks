// See https://aka.ms/new-console-template for more information
/*
 İstifadəçidən daxil etdiyi ayın nömrəsini alıb, həmin ayın hansı fəsillərə aid olduğunu ekrana çap edən bir proqram yazın.
 */




Console.Write("Ayin nomresini daxil edin: ");
string input = Console.ReadLine();

//try
//{
//    int ayinNomresi = int.Parse(input);

//    if (3 <= ayinNomresi && ayinNomresi <= 5)
//    {
//        Console.WriteLine("Yaz");
//    }
//    else if (6 <= ayinNomresi && ayinNomresi <= 8)
//    {
//        Console.WriteLine("Yay");
//    }
//    else if (9 <= ayinNomresi && ayinNomresi <= 11)
//    {
//        Console.WriteLine("Payiz");
//    }
//    else if (ayinNomresi == 12 || ayinNomresi == 1 || ayinNomresi == 2)
//    {
//        Console.WriteLine("Qish");
//    }
//    else
//    {
//        Console.WriteLine("Daxil etdiyiniz eded 1 ile 12 arasinda olmalidir.");
//    }
//}
//catch
//{ 
//    Console.WriteLine("Daxil etdiyiniz eded duzgun deyil");
//}


try
{
    int ayinNomresi = int.Parse(input);

    switch (ayinNomresi)
    {
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Yaz");
            break;
        case 6:
        case 7:
        case 8:
            Console.WriteLine("Yay");
            break;
        case 9:
        case 10:
        case 11:
            Console.WriteLine("Payiz");
            break;
        case 12:
        case 1:
        case 2:
            Console.WriteLine("Qish");
            break;
        default:
            Console.WriteLine("Daxil etdiyiniz eded 1 ile 12 arasinda olmalidir.");
            break;
    }
}

catch
{
    Console.WriteLine("Yanlis input daxil edirsiniz"); 
}