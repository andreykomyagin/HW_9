// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task64()
{
    int M = Input("Введите число M: ");
    int N = Input("Введите число N: ");
    void Test1(int M, int N)
    {
        if (M <= N)
        {
            if (M % 3 == 0)
            {
                Console.WriteLine($"{M}");
            }
            Test1(M+1, N);
        }
        else
        {
            Console.WriteLine("Все числа кратные 3-ём выведены!");
        }
    }
    Test1(M, N);
}
Task64();

void Task66()
{
    int M = Input("Введите число M: ");
    int N = Input("Введите число N: ");
    void Test2(int M, int N, int sum = 0)
    {
        if(M <= N)
        {
            sum += M;
            Test2(M+1, N, sum); 
        }
        else
        {
            Console.WriteLine($"{sum} - это итоговый ответ!");
        }
    }
    Test2(M, N);
}
Task66();

void Task68()
{
    int m = Input("Введите число M: ");
    int n = Input("Введите число N: ");
    int Test3(int m, int n)
    {
        if (m == 0)
        {
            return (n + 1);
        }
        else if ( n == 0)
        {
            return Test3(m-1, n + 1);
        }
        else if (m > 0 && n > 0)
        {
            return Test3(m-1, Test3(m, n - 1));
        }
        else
        {
            return 0;
        }
    }
    Console.WriteLine($"{Test3(m, n)}");
}
Task68();