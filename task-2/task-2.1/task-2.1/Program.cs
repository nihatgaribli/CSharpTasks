// See https://aka.ms/new-console-template for more information
/*

Aşağıdakı tiplər yaradın və aşağıda göstərilən tiplər arasında tip çevirmələri edin
float, double, decimal, int, byte, string

float --> double
double --> decimal
decimal --> float
string --> int
int --> byte
 
 */



float floatInput1 = 3.15f;
double doubleInput1 = floatInput1; //autocasting
Console.WriteLine(doubleInput1);

double doubleInput2 = 3.674576d; // d yazmayada bilerik
decimal decimalInput1 = (decimal)doubleInput2;
Console.WriteLine(decimalInput1);

decimal decimalInput2 = 643.342511154m;
float floatInput2  = (float)decimalInput2;
Console.WriteLine(floatInput2);

string stringInput1 = "5665"; 
int.TryParse(stringInput1,out int intInput1); //isSuccess
Console.WriteLine(intInput1);

int intInput2 = 500;
byte byteInput2 = (byte)intInput2;
Console.WriteLine(byteInput2);