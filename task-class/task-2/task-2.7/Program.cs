// See https://aka.ms/new-console-template for more information
/*
 
İstifadəçidən iki  ədəd daxil etməsini istəyin(biri int tipində olsun , biri string tipində). 
Daxil edilən ədədlərin cəmini hesablayın və nəticəni konsolda göstərin.

 */


using task_2._7;

int number1 = Convert.ToInt32(Console.ReadLine());
string number2 = Console.ReadLine();

Calculator calculator = new Calculator(number1, number2);
Console.WriteLine(calculator.Add());
