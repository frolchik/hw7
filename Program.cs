/* Task 1. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/

/*
double[,] CreateDoubleArray (int rows, int columns)
{
   double[,] array = new double[rows, columns];
    Random random = new Random();
   
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = random.NextDouble() * 10 ;
            array[i,j] = Math.Round(array[i,j], 2);
        }
   }        
    return array;
}         
void ShowArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}
Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
double[,] myArray = CreateDoubleArray(rows, columns);
ShowArray(myArray);

*/
/* Task 2. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает
 значение этого элемента или же указание, что такого элемента нет
 */

/*
int[,]  CreateMyArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;
}     
void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}
void ShowElementIndex(int[,] array)
{
    Console.WriteLine("Введите индекс числа строки: ");
    int indexrows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс числа столбца: ");
    int indexcolumns = Convert.ToInt32(Console.ReadLine());
    if ( indexrows > array.GetLength(0) ||  indexcolumns > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет.");
        return;
    }
    Console.WriteLine($"Значение элемента: {array[indexrows, indexcolumns]}");
}
Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());
int[,] myArray = CreateMyArray  (rows, columns, minValue, maxValue);
ShowArray(myArray);
ShowElementIndex(myArray);

*/
/*Task 3. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/



int[,]  CreateNewMyArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;

}     

void ShowArray (int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}

double[] ArithmeticMeanColumns(int[,] array, int columns, int rows)
{
        double[] columnMeans = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        double columnMean = sum / rows;
       
        //columnMeans[j] = Math.Round(columnMeans[j], 2);
        columnMeans[j] = columnMean;

        Console.WriteLine(" Сумма столбца № " + (j + 1) + " = " + sum);
        Console.WriteLine(" Среднее арифметическое столбца № " + (j + 1) + " = " + $" {columnMean:F2}");
    }

    return columnMeans;
}

Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());

int[,] myArray = CreateNewMyArray  (rows, columns, minValue, maxValue);
ShowArray(myArray);

ArithmeticMeanColumns(myArray, columns, rows);


