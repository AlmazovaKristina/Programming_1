Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= num) {
  Console.Line($"{i}");   
  i = i + 2;
}

