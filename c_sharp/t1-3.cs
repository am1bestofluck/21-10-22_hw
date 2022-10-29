using static System.Console;
class two_dimensional_array
{
    int rows;
    int columns;
    double[,] content_random_whole_numbers;
    double[,] content_random_fractured_numbers;
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
    public two_dimensional_array(int width_i, int height_i)
    {
        this.rows = width_i;
        this.columns = height_i;
        this.content_random_whole_numbers = new double[this.rows, this.columns];
        this.content_random_whole_numbers = initial_array_randomization(array_2d_i: this.content_random_whole_numbers);
        this.content_random_fractured_numbers = add_random_fraсtional_part(array_2d_i: this.content_random_whole_numbers);
    }
    protected static double[,] initial_array_randomization(double[,] array_2d_i, int limit_lower = min_i, int limit_upper = max_i)
    {
        double[,] array_2d_o = new double[array_2d_i.GetLength(0), array_2d_i.GetLength(1)];
        Random content = new Random();

        for (int row = 0; row < array_2d_i.GetLength(0); row++)
        {
            for (int column = 0; column < array_2d_i.GetLength(1); column++)
            {
                array_2d_o[row, column] = content.Next(limit_lower, limit_upper);
            }
        }
        return array_2d_o;
    }
    protected static double[,] add_random_fraсtional_part(double[,] array_2d_i, int min = min_i, int max = max_i)
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
    public static void print_2d_array(double[,] array_2d_i)
    {
        WriteLine();
        int size_rows=array_2d_i.GetLength(0), size_columns=array_2d_i.GetLength(1);
        for (int row = 0; row < size_rows; row++)
        {
            for (int column = 0; column < size_columns; column++)
            {
                Write($"{array_2d_i[row,column]} ");
            }
            WriteLine();
        }
        
    }

    public static void summarize_lines(double[,] array_2d_i)
    {
        WriteLine();
        Dictionary<int,double> ne_sli6kom_slojno_je = new Dictionary<int, double>();
        double tmp_sum;
        int size_rows=array_2d_i.GetLength(0), size_columns=array_2d_i.GetLength(1);
        for (int row = 0; row < size_rows; row++)
        {
            tmp_sum=0;
            for (int column = 0; column < size_columns; column++)
            {
                Write($"{array_2d_i[row,column]} ");
                tmp_sum+=array_2d_i[row,column];
            }
            ne_sli6kom_slojno_je.Add(
                row,
                Math.Round(tmp_sum/(size_columns*1.0),2)
                );
            WriteLine();
        }
        foreach (var item in ne_sli6kom_slojno_je)
        {
            WriteLine($"Cреднее {item.Key} = {item.Value}");  
        }
    }
    public dynamic get_value_by_indexes(int position_horizontal, int position_vertical,double[,] array_2d_i)
    {
        string output=$"Размерность массива не соответсвует запросу [{position_horizontal},{position_vertical}]";
        if (position_horizontal>array_2d_i.GetLength(0)||position_vertical>array_2d_i.GetLength(1))
        {
            return output;
        }
        output=$"Значение по адресу [{position_horizontal-1}, {position_vertical-1}]: {array_2d_i[position_horizontal-1,position_vertical-1]}";
        return output;
    }
    public dynamic main()
    {
        // Clear();
        two_dimensional_array.todo(1);
        print_2d_array(array_2d_i: this.content_random_fractured_numbers);
        two_dimensional_array.todo(2);
        WriteLine(get_value_by_indexes(
            position_horizontal:validate_input("Строка элемента?"),
            position_vertical:validate_input("Столбец элемента?"),
            array_2d_i:this.content_random_fractured_numbers));
        two_dimensional_array.todo(3);
        summarize_lines(array_2d_i:this.content_random_whole_numbers);

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