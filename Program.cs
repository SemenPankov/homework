// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return start + " " + PrintNumbers(start - 1, end);
}
System.Console.WriteLine(PrintNumbers(num, 1));



// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) 
{
    System.Console.WriteLine("Введите требуемые значения.");
    return;
}
int sum = 0;
int startPrint = num1;    
PrintSum(num1, num2);
void PrintSum(int start, int end)
{
    sum += start;
    if (start == end)
    {
        System.Console.Write($"M = {startPrint};N = {end} -> {sum}");
        return;
    }
    else
    {
        PrintSum( start + 1,  end);
        
    }
}



// Задача 68: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
System.Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int functionAkkerman = Ack(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");
int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}