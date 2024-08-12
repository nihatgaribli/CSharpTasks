// See https://aka.ms/new-console-template for more information
/*
 
 İstifadəçidən bir gün adı daxil etməsini tələb edən və bu gün adına görə iş günü, 
 həftə sonu günü və ya məlumatsız gün olduğunu yoxlayan bir proqramı yazın.
 
 */


using task_3._4;

Console.Write("Bir gun daxil edin: ");
string Day  = Console.ReadLine().ToLower();

WeekDay weekDay = new WeekDay(Day);
Console.WriteLine(weekDay.Check());
