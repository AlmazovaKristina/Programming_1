Console.Write("Введите первое число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int numC = Convert.ToInt32(Console.ReadLine());
int Max = 0;
if (numA>numB)
{
     Max = numA;
}
 else
 {
   Max = numB;  
 }

if (Max>numC)
{
  Console.WriteLine($"{Max} ");  
  
}
  else
 {
   Console.WriteLine($"{numC} ");
 }

