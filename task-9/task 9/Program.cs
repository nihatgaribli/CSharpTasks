// See https://aka.ms/new-console-template for more information
/*
 
Bir bank növbə sistemi yazın. Bankda müştərilər müxtəlif əməliyyatlar üçün növbəyə dururlar. 
Əməliyyatlar aşağıdakılardır:

Pul yatırmaq
Pul çıxarmaq
Balans yoxlamaq
Növbədən çıxmaq

Bank növbəsi Queue datastrukturu ilə idarə olunmalıdır. while dövrü istifadə edərək müştəriləri növbədə saxlayın və switch ifadəsi ilə əməliyyatları seçin.
Hər müştəri əməliyyatı bitirdikdən sonra , növbədən çıxarın.
 
 */

Queue<string> bankQueue = new Queue<string> ();
 
bankQueue.Enqueue ("client1"); 
bankQueue.Enqueue ("client2"); 
bankQueue.Enqueue ("client3"); 
bankQueue.Enqueue ("client4"); 
bankQueue.Enqueue ("client5"); 

while(true)
{
    Console.Write("\n1 - Pul yatirmaq \n2 - Pul cixarmaq \n3 - Balans Yoxlamaq \n4 - Novbeden cixmaq " +
        "\nYerine yetirmek istediyiniz emeliyyati secin: ");
    int operation = int.Parse(Console.ReadLine());

    switch (operation)
    {
        case 1:
            if (bankQueue.Count > 0)
            {
                Console.WriteLine($"{bankQueue.Dequeue()} pul yatırır.");
            }
            else
            {
                Console.WriteLine("Növbede müşteri yoxdur.");
                return;
            }
            break;

        case 2:
            if (bankQueue.Count > 0)
            {
                Console.WriteLine($"{bankQueue.Dequeue()} pul çıxarır.");
            }
            else
            {
                Console.WriteLine("Növbede müşteri yoxdur.");
                return;
            }
            break;

        case 3:
            if (bankQueue.Count > 0)
            {
                Console.WriteLine($"{bankQueue.Dequeue()} balansını yoxlayır.");
            }
            else
            {
                Console.WriteLine("Növbede müşteri yoxdur.");
                return;
            }
            break;

        case 4:
            if (bankQueue.Count > 0)
            {
                Console.WriteLine($"{bankQueue.Dequeue()} növbeden cixir.");
            }
            else
            {
                Console.WriteLine("Növbede müşteri yoxdur.");
                return;
            }
            break;

        default:
            Console.WriteLine("Yanlış seçim. Yeniden cehd edin.");
            break;
    }
}