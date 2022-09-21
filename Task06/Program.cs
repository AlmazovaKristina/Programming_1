Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int remainder = num % 2;
if (remainder == 0)
{
  Console.WriteLine("Чётное");  
}
  else
 {
   Console.WriteLine("Нечётное");
 }
