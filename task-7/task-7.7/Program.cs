// See https://aka.ms/new-console-template for more information
/*
 
Bir SortedList yaradın və onu 3 fərqli kitab adı və onların müəllifləri ilə doldurun. 
SortedList-ə yeni bir kitab əlavə edin və yenilənmiş SortedList-i konsola çap edin.
 
 */

SortedList<string, string> Books = new SortedList<string, string>();

Books.Add("1984", "George Orwell");
Books.Add("The Great Gatsby", "Scott Fitzgerald");
Books.Add("To Kill a Mockingbird", "Harper Lee");

Console.WriteLine("Ilk SortedList: ");

foreach (var book in Books)
{
    Console.WriteLine(book.Key + " - " + book.Value);
}

Books.Add("Pride and Prejudice", "Jane Austen");

Console.WriteLine("\nYeni kitab elave olunan SortedList: ");
foreach (var book in Books)
{
    Console.WriteLine(book.Key + " - " + book.Value);
}