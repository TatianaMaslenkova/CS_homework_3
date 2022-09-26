Console.Clear();

Console.WriteLine("Введите координаты точки 1 по оси x: ");
double x1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки 1 по оси y: ");
double y1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки 1 по оси z: ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки 2 по оси x: ");
double x2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки 2 по оси y: ");
double y2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки 2 по оси z: ");
double z2 = double.Parse(Console.ReadLine()!);

double s = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

Console.WriteLine($"Расстояние между точками: {s.ToString("#.00")}");