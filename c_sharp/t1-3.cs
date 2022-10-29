using static System.Console;
class two_dimensional_array
{
    int rows;
    int columns;
    double[,] contentWhole;
    double[,] contentFractured;
    const int min_i = -1000, max_i = 1000;
    public static void todo(int task)
    {
        WriteLine();
        switch (task)
        {
            case 1:
                {
                    WriteLine("Задайте двумерный массив размером m*n, заполненный случайными вещественными числами");
                    break;
                }
            case 2:
                {
                    WriteLine(@"Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Нюанс. Всякий пользователь знает что колонки и строки Мы считаем с единички.");
                    break;
                }
            case 3:
                {
                    WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
                    break;
                }
            default:
                {
                    WriteLine("May be later");
                    break;
                }
        }
    }
    public two_dimensional_array(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        this.contentWhole = new double[this.rows, this.columns];
        this.contentWhole = init(array_2d_i: this.contentWhole);
        this.contentFractured = wholeToFractured(array_2d_i: this.contentWhole);
    }
    protected static double[,] init(double[,] array_2d_i, int min = min_i, int max = max_i)
    {
        double[,] array_2d_o = new double[array_2d_i.GetLength(0), array_2d_i.GetLength(1)];
        Random content = new Random();

        for (int row = 0; row < array_2d_i.GetLength(0); row++)
        {
            for (int column = 0; column < array_2d_i.GetLength(1); column++)
            {
                array_2d_o[row, column] = content.Next(min, max);
            }
        }
        return array_2d_o;
    }
    protected static double[,] wholeToFractured(double[,] array_2d_i, int min = min_i, int max = max_i)
    {
        double[,] array_2d_o = new double[array_2d_i.GetLength(0), array_2d_i.GetLength(1)];
        double[] extend_NextDouble = new double[2];//Не удалю.
        Random content = new Random();
        double fractional_part;

        for (int row = 0; row < array_2d_i.GetLength(0); row++)
        {
            for (int column = 0; column < array_2d_i.GetLength(1); column++)
            {
                fractional_part = Math.Round(content.NextDouble(), 2);
                extend_NextDouble[0] = -fractional_part;
                extend_NextDouble[1] = fractional_part;
                array_2d_o[row, column] = array_2d_i[row, column] + extend_NextDouble[content.Next(extend_NextDouble.Length)];
            }
        }
        return array_2d_o;
    }
    public static void onScreen(double [,] array_2d_i)//достаточно кодстайлово?
    {
        WriteLine();
        int rows=array_2d_i.GetLength(0), columns=array_2d_i.GetLength(1);
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Write($"{array_2d_i[row,column]} ");
            }
            WriteLine();
        }
    }

    public static void showAverageMean(double[,] array_2d_i)
    {
        int rows=array_2d_i.GetLength(0), columns=array_2d_i.GetLength(1);
        WriteLine();
        Dictionary<int,double> ne_sli6kom_slojno_je = new Dictionary<int, double>();
        double tmp_sum;
        for (int column = 0; column < columns; column++)
        {
            tmp_sum=0;
            for (int row = 0; row < rows; row++)
            {
                tmp_sum+=array_2d_i[row,column];
            }
            ne_sli6kom_slojno_je.Add(
                column,
                Math.Round(tmp_sum*1.0/rows,2));
        }
        foreach (var item in ne_sli6kom_slojno_je)
        {
            WriteLine($"Cреднее {item.Key} = {item.Value}");  
        }
    }

    public dynamic getValue(int row, int column,double[,] array_2d_i)
    {
        string output=$"Размерность массива не соответсвует запросу [{row},{column}]";
        if (row>array_2d_i.GetLength(0)||column>array_2d_i.GetLength(1))
        {
            return output;
        }
        output=$"Значение по адресу [{row-1}, {column-1}]: {array_2d_i[row-1,column-1]}";
        return output;
    }
    public dynamic main()
    {
        two_dimensional_array.todo(1);
        onScreen(array_2d_i: this.contentFractured);
        two_dimensional_array.todo(2);
        WriteLine(getValue(
            row:validate_input("Строка элемента?"),
            column:validate_input("Столбец элемента?"),
            array_2d_i:this.contentFractured));
        two_dimensional_array.todo(3);
        onScreen(array_2d_i:this.contentWhole);
        showAverageMean(array_2d_i:this.contentWhole);

        return null!;
    }
    public static int validate_input(string invite)
    {
        int output=0;
        bool is_valid=false;
        while (output<1)
        {
            WriteLine(invite);
            is_valid=Int32.TryParse(ReadLine()!, out output);
        }
        return output;
    }


}