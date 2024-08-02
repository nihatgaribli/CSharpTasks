// See https://aka.ms/new-console-template for more information
/*
 
Bir string list yaradın və onu 5 fərqli ad ilə doldurun. 
Bu listin elementlərini konsola çap edin və listə yeni bir ad əlavə edin və sonra yenidən konsolda çap edin.
 
 */

List<string> Names = new List<string> {"Ali", "Messi", "Nihat", "Elsad", "Xalid"};

Console.WriteLine("Ilk list:");
foreach (var name in Names)
{
    Console.WriteLine(name);
}

Names.Add("Turan");

Console.WriteLine("\nAd elave olunan list:");
foreach (var name in Names)
{,
    Console.WriteLine(name);
}