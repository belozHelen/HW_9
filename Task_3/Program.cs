// Найти сумму элементов от M до N, N и M заданы

Console.Write("Введите натуральное число M: ");
double m = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
double n = Convert.ToDouble(Console.ReadLine());

double sum = 0.0;
for (double i = m; i <= n; i++) {
    sum += i;
}

Console.WriteLine(sum);