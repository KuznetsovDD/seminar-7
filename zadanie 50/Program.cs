// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.WriteLine("Введите строку: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите столбец: ");
int numb2 = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[4,4];

void FillArry(int[,] arry)
{
    for(int i=0; i<arry.GetLength(0); i++)
    {
       for(int j=0; j<arry.GetLength(1); j++) 
       {
        arry[i,j] = new Random().Next(-99,100);
       }
    }
}
void PrintArray(int[,] matr)
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

void PrintMean(int [,] arr)
{
    var mean = 0;
    int num1 = numb1-1;
    int num2 = numb2-1;
    try
    {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] == arr[num1,num2])
            {
                mean = array[i,j];
                System.Console.WriteLine(mean);
            }            
        }      
    }   
    }
    catch
    {
        System.Console.WriteLine("Нет значения"); 
    } 
}

System.Console.WriteLine();
FillArry(array);
PrintArray(array);
System.Console.WriteLine();
PrintMean(array);
