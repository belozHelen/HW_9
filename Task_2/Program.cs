// Показать натуральные числа от M до N, N и M заданы

Console.Write("Введите натуральное число M: ");
double m = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
double n = Convert.ToDouble(Console.ReadLine());

if ((n <= 0 || n % 1 != 0) || (m <= 0 || m % 1 != 0)) {
    Console.WriteLine("m или n не натуральное число");
    return;
} else if (m > n) {
    Console.WriteLine("m не может быть меньше n");
    return;
}

Console.WriteLine(m + " " + GetStringResult(n, m, ""));

string GetStringResult(double num, double iter, string str)
{
    iter++;

    if (iter > num) {
        return str;
    } 

    return iter + " " + GetStringResult(num, iter, str);
}
