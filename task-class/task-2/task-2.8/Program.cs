// See https://aka.ms/new-console-template for more information

/*
  
 İstifadəçidən string tipində ədəd daxil etməsini tələb edin. Daxil edilən ədədi int tipinə çevirin. 
 Əgər int tipinə çevirilirsə çevirsin, çevirmək mümkün deyilsə istifadəçiyə message qaytarsın 
 
 */

using task_2._8;

string str = Console.ReadLine();

Convertor convertor = new Convertor(str);
convertor.Convert();