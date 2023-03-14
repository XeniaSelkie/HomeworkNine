void Main()
{
    while (true)
    {
        int task = ReadInt("номер задания");

        switch (task)
        {
            case 64: Task64(); break;
            case 66: Task66(); break;
            case 68: Task68(); break;
        }
    }
}

void Task64() // Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
{
    int n = ReadInt("число");
    int one = 1;
    AllNaturalNumberFromOneToN(n, one);
}

void Task66() // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
{
    int n = ReadInt("первое число");
    int m = ReadInt("второе число");
    int sum = 0;
        
    if (n > m)
    {
        Console.WriteLine($"Сумма чисел от {m} до {n} равняется: {SumNaturalNumbersFtomMToN(n, m, sum)}");
    }
    else
    {
        Console.WriteLine($"Сумма чисел от {m} до {n} равняется: {SumNaturalNumbersFtomMToN(m, n, sum)}");
    }
}

void Task68() // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
{
    int m = ReadIntForAckermann("первое число");
    int n = ReadIntForAckermann("второе число");
    AckermannFunction(m, n);
}

int ReadInt(string argument)
{
    int number;
    Console.Write($"Введите {argument}: ");

    while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
    {
        Console.WriteLine("Ошибка ввода, пожалуйста, введите натуральное число");
    }

    return number;
}

void AllNaturalNumberFromOneToN(int n, int m)
{
    Console.Write($"{n} ");
    if (n > m)
    {
        AllNaturalNumberFromOneToN(n-1, m);
    }
}

int SumNaturalNumbersFtomMToN (int firstNumber, int secondNumber, int sum)
{
    sum = sum + firstNumber;
    if (firstNumber <= secondNumber)
    {
        return sum;
    }
    else
    {
        return SumNaturalNumbersFtomMToN(firstNumber-1, secondNumber, sum);
    }    
}

int ReadIntForAckermann(string argument)
{
    int number;
    Console.Write($"Введите {argument}: ");

    while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
    {
        Console.WriteLine("Ошибка ввода, пожалуйста, введите натуральное число");
    }

    return number;
}

void AckermannFunction(int m, int n)
{
    double A;

    if (m == 0)
    {
        A = n + 1;
    }
    else
    {
        if (m == 1)
        {
            A = n + 2;
        }
        else
        {
            if (m == 2)
            {
                A = 2* n + 3;
            }
            else
            {
                A = Math.Pow(2, n+3) - 3;
            }
        }
    }

Console.WriteLine($"Результат вычисления функции Аккермана для следующих чисел {m} и {n} равен {A}");
}