int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int c = Int32.Parse(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine($"max = {a}");
}
else if (b > c && b > a)
{
    Console.WriteLine($"max = {b}");
}
else
{
    Console.WriteLine($"max = {c}");
}