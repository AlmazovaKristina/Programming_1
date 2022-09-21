Console.Write("Введите первое число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA>numB)
{
  Console.WriteLine($"Число {numA} больше числа {numB} ");  
}
Console.WriteLine($"Число {numB} больше числа {numA} "); 
