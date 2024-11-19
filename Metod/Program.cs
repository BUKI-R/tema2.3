using System;
void Hel(int a, int b)
{
    int result = a + b;
    Console.WriteLine($"{a}+{b}={result}");
}
Console.WriteLine($"Введите 2 значения a и b");
Console.Write("a= ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("b= ");
int y = Convert.ToInt32(Console.ReadLine());
Hel(x, y);
private void people(string name, int age)
{
    Console.WriteLine($"Имя пользователя:{name};");
    Console.WriteLine($"Возраст пользователя:{age};");
}
string na = Console.ReadLine();
int ag = Convert.ToInt32(Console.ReadLine());
people(na,ag);