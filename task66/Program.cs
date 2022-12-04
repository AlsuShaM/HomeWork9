// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNumbers(int M, int N)
{
    if (M == N) return M;                      
        else if (M < N) return N + SumNumbers(M, N - 1); 
        else if (N == 0 && M == 0) return (M * (M + 1)) / 2;    
        else return N + SumNumbers(M, N + 1);      
}

int M = 1;
int N = 15;
Console.WriteLine($"Сумма натуральных элементов в промежутке от M({M}) до N({N}) = {SumNumbers(M, N)}");;