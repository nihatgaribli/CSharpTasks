// See https://aka.ms/new-console-template for more information
/*
 
 Bir ArrayList yaradın və ora bir neçə tam ədəd əlavə edin (bəziləri təkrar ola bilər).
Foreach döngüsündən istifadə edərək, ArrayList-də olan bütün unikal elementləri tapın və onları başqa bir ArrayList-ə əlavə edin.
Unikal elementləri ekrana çap edin.
 
*/

using System.Collections;

ArrayList Elements = new ArrayList { 1, 2, 6, 5, 5, 4, 3, 2, 1 };
ArrayList unikalElements = new ArrayList();

foreach (int i in Elements)
{
    bool isUnique = true;

    foreach (int j in unikalElements)
    {
        if (i == j)
        {
            isUnique = false;
            break;
        }
    }

    if (isUnique)
    {
        unikalElements.Add(i);
    }
}

foreach (int i in unikalElements)
{
    Console.Write(i + " ");
}
