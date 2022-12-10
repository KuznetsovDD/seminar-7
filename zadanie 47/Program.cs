// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.WriteLine("Введите количество строк: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int numb2 = Convert.ToInt32(Console.ReadLine());


double[,] array = new double[numb1, numb2];

double[,] FillArry(double[,] arry)
{
    for(int i=0; i<arry.GetLength(0); i++)
    {
       for(int j=0; j<arry.GetLength(1); j++) 
       {
        arry[i,j] =  Math.Round(new Random().NextDouble()*10, 1);
       }
    }
    return arry;
}
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

PrintArray(FillArry(array));