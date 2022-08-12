/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.*/
Console.Clear();
int x = new Random().Next(100,1000);
string num = f(x);
Console.WriteLine ($" {x}");
Console.WriteLine ($" {num} - третья цифра заданного числа");
string f ( int x )
{
   
           int a2 = x%10;
        string b2 = a2.ToString();
        string num = b2;
        return num;
}

