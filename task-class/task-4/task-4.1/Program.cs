// See https://aka.ms/new-console-template for more information
/*
 
 Bir proqram yazın ki, istifadəçinin daxil etdiyi  rəqəmin faktorialını hesablasın.(while ilə)
 
 */

using task_4._1;

Console.Write("Ededi daxil edin");
int number = Convert.ToInt32(Console.ReadLine());

Factorial factorial = new Factorial(number);
Console.WriteLine(factorial.fac());