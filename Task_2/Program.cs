double Pifagor(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((Math.Pow((x2-x1),3))+(Math.Pow((y2-y1),3))+(Math.Pow((z2-z1),3)));
    return result;
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int x1 = EnterData("Введите x1 :");
int y1 = EnterData("Введите y1 :");
int z1 = EnterData("Введите z1 :");
int x2 = EnterData("Введите x2 :");
int y2 = EnterData("Введите y2 :");
int z2 = EnterData("Введите z2 :");
double result = Pifagor(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Расстояние равно {result}");