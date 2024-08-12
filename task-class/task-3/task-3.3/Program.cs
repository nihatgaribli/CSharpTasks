// See https://aka.ms/new-console-template for more information
/*
 
  İstifadəçidən bir tam ədəd daxil etməsini tələb edən və bu ədədin pozitiv, mənfi və ya sıfır olduğunu yoxlayan bir  proqramı yazın
 
 */


using task_3._3;

Console.Write("Bir eded daxil edin: ");
int number = Convert.ToInt32(Console.ReadLine());


Numbers numbers = new Numbers(number);
Console.WriteLine(numbers.Check());