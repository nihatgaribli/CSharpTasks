// See https://aka.ms/new-console-template for more information

/*

Bir ArrayList yaradın və onu integer dəyərlərlə doldurun. 
ArrayList-in elementlərini konsola çap edin, sonra yeni elementlər əlavə edin və yenidən çap edin.

*/

using System.Collections;

ArrayList intValues = new ArrayList { 1, 2, 3, 4, 5 };

Console.Write("ArrayList: ");
for( int i = 0; i < intValues.Count; i++ )
{
    Console.Write(intValues[i] + " ");
}

intValues.Add( 6 );

Console.Write("\nYeni element elave olunmus ArrayList: ");
for (int i = 0; i < intValues.Count; i++)
{
    Console.Write(intValues[i] + " ");
}

