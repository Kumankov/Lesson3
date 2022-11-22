//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//Task19();
void Task19 ()
{
Console.WriteLine("Введите пятизначное число для задачи 19:");
string N13 = Console.ReadLine();
int len = N13.Length;
if (len!=5)
Console.WriteLine("введено не пятизначное число");
else
    {
        if ((N13.Substring(0,1)==N13.Substring(4,1)) && (N13.Substring(1,1)==N13.Substring(3,1)))
        Console.WriteLine($"Число {N13} палиндром");
        else
        Console.WriteLine($"Число {N13} не палиндром");
    }
}

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
//Task23 ();
void Task23 ()
{
Console.WriteLine("Введите число N для задачи 23:");
int N = int.Parse(Console.ReadLine());
for (int i=1;i<=N;i++)
    {
    if (i==N)
    Console.Write(Math.Pow(i,3));
    else
    Console.Write($"{Math.Pow(i,3)}, ");
    }
}

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//Task21 ();
void Task21 ()
{
double[] pointA = new double[3];
double[] pointB = new double[3];
double average =0;
Console.WriteLine("Введите число координату x точки A:");
pointA[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число координату y точки A:");
pointA[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число координату z точки A:");
pointA[2] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число координату x точки B:");
pointB[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число координату y точки A:");
pointB[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число координату z точки A:");
pointB[2] = Convert.ToDouble(Console.ReadLine());
for (int i=0;i<3;i++)
    {
    average = average + Math.Pow((pointA[i]-pointB[i]),2);
    }
average = Math.Sqrt(average);
Console.Write(average);
}
