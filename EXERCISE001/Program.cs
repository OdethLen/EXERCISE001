
//Exercise #1. Enter degrees Celsius -> the program will convert them into Farenheit and Kelvin
//kelvin = celsius + 273
//fahrenheit = celsius x 18/10 + 32
double Degrees, F, K;
Console.Write("Enter the degrees °C:");
Degrees = Convert.ToDouble(Console.ReadLine());
F = ((Degrees * 18) / 10) + 32;
K = Degrees + 273;
Console.WriteLine("F°:" + F);
Console.WriteLine("K°:" + K);
Console.ReadKey();