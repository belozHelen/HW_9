// Показать натуральные числа от 1 до N, N задано

Console.Write("Введите натуральное число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num <= 0 || num % 1 != 0) {
    Console.Write("введено не натуральное число");
    return;
}

Console.WriteLine(GetStringResult(num, 0, ""));

string GetStringResult(double num, int iter, string str)
{
    iter++;

    if (iter > num) {
        return str;
    } 

    return iter + " " + GetStringResult(num, iter, str);
}