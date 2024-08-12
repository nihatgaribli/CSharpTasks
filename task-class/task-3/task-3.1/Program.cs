// See https://aka.ms/new-console-template for more information
/*
 
  İstifadəçidən daxil etdiyi ayın nömrəsini alıb, həmin ayın hansı fəsillərə aid olduğunu ekrana çap edən bir proqram yazın
 
 */

using task_3._1;

Console.Write("Ayin nomresini axil edin: ");
int number = Convert.ToInt32(Console.ReadLine());

Months months = new Months(number);
Console.WriteLine(months.monthsName());