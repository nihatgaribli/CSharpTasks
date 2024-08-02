/*

Bir istifadəçi bir sıra tam ədədləri daxil edir. Bu ədədləri oxumaq və onların müxtəlif əməliyyatlarını yerinə yetirmək üçün while 
döngüsü və switch  istifadə edən bir proqram yazın.

Əməliyyatlar:
Ədədləri daxil edin: İstifadəçi ədəd daxil edəcəkdir. Ədəd daxil etməyi bitirmək üçün istifadəçi "0" daxil etməlidir.
Ədədləri təhlil edin:
Əgər ədəd müsbətdirsə, ədədin kvadratını hesablayın  və nəticəni çıxarın.
Əgər ədəd mənfidir, ədədin mütləq dəyərini tapın və nəticəni çıxarın.
Əgər ədəd sıfırdırsa, bir mesaj göstərin. 
Əməliyyat növünü seçin: İstifadəçi əməliyyat növünü seçə bilər:
1 - Müsbət ədədlərin kvadratını çıxarmaq
2 - Mənfi ədədlərin mütləq dəyərini çıxarmaq
3 - Sıfır olan ədədlərin olduğunu göstərmək
0 - Çıxış
 
 */

#region massiv_ile
//int[] array = new int[101];
//int index = 0;

//try
//{
//    Console.WriteLine("Ededleri daxil edin (daxil etmeni bitirmek uchun 0 yazin): ");
//    while (true)
//    {
//        int eded = Convert.ToInt32(Console.ReadLine());
//        if (eded == 0) break;
//        else
//        {
//            array[index++] = eded;
//        }
//    }

//    Console.WriteLine("Emeliyyat novunu secin: \n1 - Musbet ededlerin kvadratini cixarmaq \n2 - Menfi edelerin mutleq deyerini cixarmaq" +
//        " \n3 - Sifir olan ededlerin oldugunu gostermek \n0 - Cixis");

//    while (true)
//    {

//        int emeliyyat_novu = Convert.ToInt32(Console.ReadLine());

//        switch (emeliyyat_novu)
//        {
//            case 1:
//                Console.WriteLine("Musbet ededlerin kvadrati:");
//                foreach (int i in array)
//                {
//                    if (i > 0)
//                    {
//                        Console.WriteLine($"{i} ededinin kvadrati: {i * i}");
//                    }
//                }
//                break;

//            case 2:
//                Console.WriteLine("Menfi edelerin mutleq deyeri:");
//                foreach (int i in array)
//                {
//                    if (i < 0)
//                    {
//                        Console.WriteLine($"|{i}| = {i * -1}"); //{Math.Abs(i)}
//                    }
//                }
//                break;

//            case 3:
//                Console.Write("Sifir olan ededlerin oldugunu gostermek: ");
//                foreach (int i in array)
//                {
//                    if (i == 0)
//                    {
//                        Console.WriteLine("Sifir daxil edilib");
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Sifir daxil edilmeyib");
//                        break;
//                    }
//                }
//                break;

//            case 0:
//                Console.WriteLine("Proqramdan cixis.");
//                return;

//        }
//    }
//}

//catch
//{
//    Console.WriteLine("Yanlis Input daxil etmisiniz");
//}
#endregion






#region string_ile


string input, ededler = "";
int eded;
bool varSifir = false;

Console.WriteLine("Ededleri daxil edin (dayandirmaq ucun 0 daxil edin): ");

while (true)
{
    input = Console.ReadLine();
    if (input == "0")
    {
        varSifir = true;
        break;
    }
    else
    {
        ededler += input + " ";
    }
}

Console.WriteLine("1 - Musbet ededlerin kvadratini cixarmaq \n2 - Menfi edelerin mutleq deyerini cixarmaq" +
        " \n3 - Sifir olan ededlerin oldugunu gostermek \n0 - Cixis");

while (true)
{
    Console.Write("Emeliyyat novunu secin: ");

    int emeliyyat_novu = Convert.ToInt32(Console.ReadLine());

    switch (emeliyyat_novu)
    {
        case 1:
            foreach (var i in ededler.Split())
            {
                if (int.TryParse(i, out eded) && eded > 0)
                {
                    Console.WriteLine($"{eded} ededinin kvadrati: {eded * eded}");
                }
            }
            break;

        case 2:
            foreach (var i in ededler.Split())
            {
                if (int.TryParse(i, out eded) && eded < 0)
                {
                    Console.WriteLine($"|{eded}| = {eded * -1}");
                }
            }
            break;

        case 3:
            if (varSifir)
            {
                Console.WriteLine("Sifir ededi daxil edilib");
            }
            else
            {
                Console.WriteLine("Sifir edei daxil edilmeyib");
            }
            break;

        case 0:
            Console.WriteLine("Proqram bitdi.");
            return;

        default:
            Console.WriteLine("Yanlis input daxil etmisiniz");
            break;
    }
}

#endregion






#region list

//List<int> ededler = new List<int>();
//int eded;
//bool varSifir = false;

//try
//{
//    Console.WriteLine("Ededleri daxil edin( Bitirmek uchun 0 yazin): ");
//    while (true)
//    {
//        eded = int.Parse(Console.ReadLine());
//        if (eded != 0)
//        {
//            ededler.Add(eded);
//        }
//        else
//        {
//            varSifir = true;
//            break;
//        }
//    }

//    Console.WriteLine("\n1 - Musbet ededlerin kvadratini gostermek \n2 - Menfi ededlerin modulunu \n3 - Sifir olan ededi" +
//        "\n0 - Proqramdan cixis");

//    while(true) 
//    {
//        Console.Write("\nEmeliyyatin novunu daxil edin: ");
//        int emeliyyat = int.Parse(Console.ReadLine());

//        switch (emeliyyat)
//        {
//            case 1:
//                foreach (int i in ededler)
//                {
//                    if(i > 0)
//                    {
//                        Console.WriteLine($"{i} ededinin kvadrati:{i*i}");
//                    }
//                }
//                break;

//            case 2:
//                foreach (int i in ededler)
//                {
//                    if (i < 0)
//                    {
//                        Console.WriteLine($"|{i}| = {i * -1}");
//                    }
//                }
//                break;

//            case 3:
//                if(varSifir)
//                {
//                    Console.WriteLine("Sifir daxil edilib");
//                }
//                else
//                {
//                    Console.WriteLine("Sifir daxil edilmeyib");
//                }
//                break;

//            case 0:
//                Console.WriteLine("Proqram bitdi");
//                return ;
//            default:
//                Console.WriteLine("Yanlis input daxil etmisiniz.");
//                break;
//        }
//    }
//}

//catch
//{
//    Console.WriteLine("Yanlis input daxil etmisiniz");
//}


#endregion