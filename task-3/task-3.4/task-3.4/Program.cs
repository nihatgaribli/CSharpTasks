// See https://aka.ms/new-console-template for more information
/*
 
İstifadəçidən bir gün adı daxil etməsini tələb edən və bu gün adına görə iş günü, 
həftə sonu günü və ya məlumatsız gün olduğunu yoxlayan bir proqramı yazın.
 
 */


Console.Write("Gunu daxil edin: ");
string gun = Console.ReadLine();

gun = gun.ToLower();

//if(gun == "bazar ertesi" || gun == "cersenbe axsami" || gun == "cersenbe" || gun == "cuma axsami" || gun == "cuma")
//{
//    Console.WriteLine("Bu gun ish gunudur");
//}
//else if(gun == "senbe" || gun == "bazar")
//{
//    Console.WriteLine("Bu gun hefto sonudur");
//}
//else
//{
//    Console.WriteLine("Bu gun haqqinda melumatsizam");
//}

switch (gun)
{
    case "bazar ertesi":
    case "cersenbe axsami":
    case "cersenbe":
    case "cuma axsami":
    case "cuma": 
        Console.WriteLine("Bu gun ish gunudur");
        break;
    case "senbe":
    case "bazar":
        Console.WriteLine("Bu gun hefto sonudur");
        break;
    default:
        Console.WriteLine("Bu gun haqqinda melumatsizam"); 
        break;
}