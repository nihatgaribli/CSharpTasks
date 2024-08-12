// See https://aka.ms/new-console-template for more information

/*
 
Aşağıdakı tiplər yaradın və aşağıda göstərilən tiplər arasında tip çevirmələri edin
float, double, decimal, int, byte, string

float --> double
double-->decimal
decimal-->float
string--> int
int --> byte
 
 */


using task_2;

Converter converter = new Converter();

float input1 = 1232.353f;
double number1 = converter.ToDouble(input1);
Console.WriteLine(number1 +" " + number1.GetType().Name);

double input2 = 2413432.43223113;
decimal number2 = converter.ToDecimal(input2);
Console.WriteLine(number2 + " " + number2.GetType().Name);

decimal input3 = 7267.2345m;
float number3 = converter.ToFloat(input3);
Console.WriteLine(number3 + " " + number3.GetType().Name);

string input4 = "624276";
int number4 = converter.ToInt(input4);
Console.WriteLine(number4 + " " + number4.GetType().Name);

int input5 = 400;
byte number5 = converter.ToByte(input5);
Console.WriteLine(number5 + " " + number5.GetType().Name);

