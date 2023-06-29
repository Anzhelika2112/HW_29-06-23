// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear(); 

double num = GetNumberFromUser("Введите значение b1: ", "Ошибка ввода!");
double num1 = GetNumberFromUser("Введите значение k1: ", "Ошибка ввода!");
double num2 = GetNumberFromUser("Введите значение b2: ", "Ошибка ввода!");
double num3 = GetNumberFromUser("Введите значение k2: ", "Ошибка ввода!");

double GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(double.TryParse(Console.ReadLine(), out double userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double x = (-num2 + num)/(-num1 + num3);
double y = num3 * x + num2;

Console.WriteLine($"b1 = {num}, k1 = {num1}, b2 = {num2}, k2 = {num3}, -> ({x}; {y})");