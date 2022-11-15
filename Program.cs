//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
/*
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int end = 1;
string res = PrintNumber(num, end);
Console.WriteLine($"Промежуток от N до 1: {res}");
string PrintNumber(int start, int end){
    if (start == end) return start.ToString();
    return start + " " + PrintNumber(start-1, end); 
}
*/

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.WriteLine("Введите значения: ");
int M = int.Parse(Console.ReadLine()!);
int N = int.Parse(Console.ReadLine()!);
int res = SumNumber(M, N);

Console.WriteLine($"Сумма значений от M до N: {res}");
int SumNumber(int start, int end){
    if (start == end) return start;
    return start + SumNumber(start+1, end);
}
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n.
/*
Console.WriteLine("Введите два неотрицательных числа: ");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
if ((m >= 0) && (n >= 0)){
    int res = FuncAkkerman(m, n);
    Console.WriteLine($"Значение функции Аккермана = {res}");
}else{
    Console.WriteLine("Введены отрицательные числа!");
}

int FuncAkkerman(int m, int n){
    if(m == 0) return n+1;
    else if (m !=0 && n == 0) return FuncAkkerman(m-1, 1);
    else return FuncAkkerman(m-1,FuncAkkerman(m, n-1));
}
*/