Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine());

int a1 = number/10000;
int a2 = number%10;
int a3 = (number/1000)%10;
int a4 = (number%100)/10;
if (a1 == a2 && a3 == a4)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}