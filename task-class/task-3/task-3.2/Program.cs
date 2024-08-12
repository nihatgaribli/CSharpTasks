// See https://aka.ms/new-console-template for more information


/*
 
 İstifadəçidən imtahan nəticəsini daxil etməsini tələb edən və bu nəticəyə görə uyğun kateqoriyayı (
 əla, yaxşı, orta, zəif) ekrana çap edən bir proqramı yazın.
 
 */

using task_3._2;

Console.Write("Imtahan neticenizi daxil edin: ");
int result = Convert.ToInt32(Console.ReadLine());

Exam exam = new Exam(result);
Console.WriteLine(exam.ExamResult());
