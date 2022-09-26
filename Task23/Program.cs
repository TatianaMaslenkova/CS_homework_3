Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 1;

if(n < 1)
{
    Console.WriteLine("Введите положительное число!");
}
else
{
    while(count <= n)
    {
        Console.Write(Math.Pow(count, 3));
        if(count != n)
            Console.Write(", ");
        count++;
    }
    
}