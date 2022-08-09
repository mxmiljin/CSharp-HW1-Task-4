Console.WriteLine("Введите первое число:");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int Number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int Number3 = Convert.ToInt32(Console.ReadLine());

int Max = Number1;
if (Max < Number2)
{
    Max = Number2;
}
if (Max < Number3)
{
    Max = Number3;
}

Console.Write("Максимальное число: ");
Console.WriteLine(Max);