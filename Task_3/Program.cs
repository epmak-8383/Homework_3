int EnterData(string text)
{
    Console.Write(text);
    int N = int.Parse(Console.ReadLine());
    return N;
}

void Sqr(int N)
{
    N=N*N*N;
    Console.Write(N + ", ");
}
int N = EnterData("Введите число: ");
int i=1;
while (i<=N)
{
    Sqr(i);
    i++;
}