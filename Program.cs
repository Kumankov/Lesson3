Task19();
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


Task23 ();
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
