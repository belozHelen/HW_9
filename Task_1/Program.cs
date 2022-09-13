// Показать натуральные числа от N до 1, N задано

Console.Write("Введите натуральное число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num <= 0 || num % 1 != 0) {
    Console.Write("введено не натуральное число");
    return;
}

string str = "";
for (int i = 1; i <= num; i++) {
    str += i + " ";
}

Console.WriteLine(str);
