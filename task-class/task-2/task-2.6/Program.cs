// See https://aka.ms/new-console-template for more information
/*
 
 İstifadəçidən iki tam ədəd daxil etməsini tələb edin. 
 Daxil edilən ədədləri bir-birinə bölün və qalıq hissəni konsolda göstərin. 
 Qeyd: Bölünən ədədin 0-a bölünməsinə nəzərə alın.
 
 */

using task_2._6;

Console.WriteLine("Ededleri daxil edin: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

Calculator calculator = new Calculator(number1, number2);
calculator.Funcsion();