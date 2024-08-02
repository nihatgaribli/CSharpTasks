// See https://aka.ms/new-console-template for more information
/*
 
Bir Queue yaradın və ora bir neçə işin adını əlavə edin.
Hər bir iş icra olunmadan əvvəl işin adını ekrana çap edin və sonra növbədən çıxarın.
Bütün işlər icra olunduqdan sonra növbənin boş olub olmadığını yoxlayın və nəticəni ekrana çap edin.
 
 */

using System.Collections.Generic;

Queue<string> Work = new Queue<string>();
Work.Enqueue("Surucu");
Work.Enqueue("Muellim");
Work.Enqueue("Derzi");
Work.Enqueue("Satici");


while (Work.Count > 0)
{
    Console.WriteLine( "Gorulen is: " + Work.Dequeue() );
}

if (Work.Count == 0)
{
    Console.WriteLine("\nBosdur");
}
else
{
    Console.WriteLine("\nBos deyil");
}