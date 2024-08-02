// See https://aka.ms/new-console-template for more information
/*
 
Bir Dictionary yaradın və onu 5 fərqli tələbə adı və onların yaşları ilə doldurun. Bu Dictionary-nin elementlərini konsola çap edin.
 
 */

Dictionary <string,int> Students = new Dictionary<string,int>();

Students.Add("Ali", 18);
Students.Add("Anar", 19);
Students.Add("Farid", 20);
Students.Add("Tahir", 21);
Students.Add("Vali", 20);

foreach (var student in Students)
{
    Console.WriteLine(student.Key + " - " + student.Value);
}