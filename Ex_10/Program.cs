Console.WriteLine("Ведите первое число");
string? A = ReadLine();
double a;
if (double.TryParse(A, out a))
    {
      // Преобразовать A в а  
    }
else
    {
        Console.WriteLine("Ошибка ввода");
    }
Console.WriteLine("Ведите второе число");
string? B = ReadLine();
double b;
if (double.TryParse(B, out b))
    {
       // Преобразовать B в b  
    }
else
    {
        Console.WriteLine("Ошибка ввода");
    }
if (a == b*b) 
    {
    Console.WriteLine("Первое число является квадратом второго числа");  
    }
else 
    {
    Console.WriteLine("Первое число не является квадратом второго числа");  
    }

