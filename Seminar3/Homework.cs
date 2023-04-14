// Задача 1.Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

/*
bool Palindrom(int origNumber)
{
int number = origNumber;
int revNumber = 0;
while(number > 0)
{
    revNumber = (revNumber * 10) + (number % 10);
    number = number / 10;
}
if(revNumber == origNumber) return true;
else return false;
}

Console.Write("Введите число: ");
int origNumber = Convert.ToInt32(Console.ReadLine());
if (Palindrom(origNumber)) Console.WriteLine($"Число {origNumber} является палиндромом");
else Console.WriteLine($"Число {origNumber} не является палиндромом");
*/

// Задача 2. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double Lenght(double x1, double x2, double y1, double y2, double z1, double z2)
{
return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

Console.Write("Введите координаты 'x' точки A: ");
double aX = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты 'y' точки A: ");
double aY = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты 'z' точки A: ");
double aZ = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты 'x' точки B: ");
double bX = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты 'y' точки B: ");
double bY = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты 'z' точки B: ");
double bZ = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками А и В: {Math.Round(Lenght(aX, bX, aY, bY, aZ, bZ), 2 )}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int num)
{
int i = 1;
while(i <= num)
{
    Console.Write($"{Math.Pow(i, 3)} ");
    i++;
}
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
*/
