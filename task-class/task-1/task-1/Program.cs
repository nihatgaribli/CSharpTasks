// See https://aka.ms/new-console-template for more information

using task_class1;

Console.Write("Daxil edin: ");
string Input = Console.ReadLine();

InputAnalyzer analyzer = new InputAnalyzer(Input);
analyzer.Analyze();
