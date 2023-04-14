// Задача 1. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowRange(int quad)
{
    if(quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if(quad == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong number of quadrant!");
}

Console.Write("Input a number of quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowRange(quadrant);
*/

// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y),
//  и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int ReturnCoord(double x, double y)
{
    
    if(x > 0 && y > 0) return 1;
    else if(x < 0 && y > 0) return 2;
    else if(x < 0 && y < 0) return 3;
    return 4;
}

Console.Write("Введите координату X: ");
double coordX = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double coordY = Convert.ToDouble(Console.ReadLine());
int coord = ReturnCoord(coordX, coordY);
Console.Write($"Номер четверти: {coord}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу квадратов чисел от 1 до N.

/*
void QuadTabl(double N)
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine($"Квадрат {count} = {count * count}");
        count++;
    }
}

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
QuadTabl(num);
*/

// Задача 4. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
/*
double Gip(double x1, double y1, double x2, double y2)
{
    double distX = x2 - x1;
    double distY = y2 - y1;
    double result = Math.Sqrt(distX*distX + distY*distY);
    return result;
}

Console.Write("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние между точками 'x' и 'y': {Gip(x1, y1, x2, y2)}");
*/