// See https://aka.ms/new-console-template for more information

/*
 
 Bir proqram yazın ki, istifadəçidən bir tam ədəd qəbul etsin və bu ədədin rəqəmlərinin cəmini while dövrü istifadə edərək hesablasın. 
 Məsələn, istifadəçi 1234 daxil etsə, proqram 1 + 2 + 3 + 4 = 10 hesablamalıdır.(do-while ilə)
 
 */

using task_4._2;

Console.Write("Ededi daxil edin: ");
int number = Convert.ToInt32(Console.ReadLine());

Sum sum = new Sum(number);
Console.WriteLine(sum.sumDigits());