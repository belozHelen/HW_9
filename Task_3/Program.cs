// Найти сумму элементов от M до N, N и M заданы

Console.Write("Введите натуральное число M: ");
double m = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
double n = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetResult(n, m, 0.0));

double GetResult(double num, double iter, double sum)
{   
    if (iter > num) {
        return sum;
    } 

    sum += iter;
    iter++;

    return GetResult(num, iter, sum);
}