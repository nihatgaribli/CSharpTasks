// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*

İstifadəçidən bir ədəd daxil etməsini istəyən bir proqram yazın.
Daxil edilən ədədi aşağıdakı məlumat tiplərinə çevirin və nəticələri ekrana çap edin(byte, int, long,char,bool)

 */

Console.Write("Bir eded daxil edin:");
string n = Console.ReadLine();

byte b = byte.Parse(n);
int m = int.Parse(n);
long l = long.Parse(n);
char c = char.Parse(n);
bool h = bool.Parse(n);

Console.WriteLine($"byte:{b}\nint:{m}\nlong:{l}\nchar:{c}\nbool:{h}");