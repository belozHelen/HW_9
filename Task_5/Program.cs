// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) {
    Console.Write("m не может быть меньше n в заданной последовательности'");
    return;
}

Console.WriteLine(GetStringResult(n, m, ""));

string GetStringResult(double num, int iter, string str)
{
    if (iter > num) {
        return str;
    } 

    str += (iter - 2) + (iter - 1) + " ";
    iter++;

    return GetStringResult(num, iter, str);
}