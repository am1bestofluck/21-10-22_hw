using static System.Console;
class two_dimensional_array
{
    int width;
    int height;
    double[,] content_random_whole_numbers;
    double[,] content_random_fractured_numbers;
    const int border_lower = -1000, border_upper = 1000;
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
                    WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
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
        this.width = width_i;
        this.height = height_i;
        this.content_random_whole_numbers = new double[this.width, this.height];
        this.content_random_whole_numbers = initial_array_randomization(array_2d_i: this.content_random_whole_numbers);
        this.content_random_fractured_numbers = add_random_fraсtional_part(array_2d_i: this.content_random_whole_numbers);
    }
    protected dynamic initial_array_randomization(double[,] array_2d_i, int limit_lower = border_lower, int limit_upper = border_upper)
    {
        double[,] array_2d_o = new double[array_2d_i.GetLength(0), array_2d_i.GetLength(1)];
        Random content = new Random();

        for (int horizontal_step = 0; horizontal_step < array_2d_i.GetLength(0); horizontal_step++)
        {
            for (int vertical_step = 0; vertical_step < array_2d_i.GetLength(1); vertical_step++)
            {
                array_2d_o[horizontal_step, vertical_step] = content.Next(limit_lower, limit_upper);
            }
        }
        return array_2d_o;
    }
    protected dynamic add_random_fraсtional_part(double[,] array_2d_i, int limit_lower = border_lower, int limit_upper = border_upper)
    {
        double[,] array_2d_o = new double[array_2d_i.GetLength(0), array_2d_i.GetLength(1)];
        double[] yeah_no = new double[2];
        Random content = new Random();
        double fractional_part;

        for (int horizontal_step = 0; horizontal_step < array_2d_i.GetLength(0); horizontal_step++)
        {
            for (int vertical_step = 0; vertical_step < array_2d_i.GetLength(1); vertical_step++)
            {
                fractional_part = Math.Round(content.NextDouble(), 2);
                yeah_no[0] = -fractional_part;
                yeah_no[1] = fractional_part;
                array_2d_o[horizontal_step, vertical_step] = array_2d_i[horizontal_step, vertical_step] + yeah_no[content.Next(yeah_no.Length)];//=) ._. не можно ругаться в комментариях XDDD
            }
        }
        return array_2d_o;
    }
    public dynamic print_2d_array(double[,] array_2d_i)
    {
        //we enjoy typing или усложнение кода за счёт множественных if. ну ок =\
        string sup_val_line;
        string left_border = "| ", right_border = " |", separator = " | ";
        string[] sup_arr_line;
        int max_expression_length = 0;
        string expression_stringified = String.Empty;
        for (int horizontal_step = 0; horizontal_step < array_2d_i.GetLength(0); horizontal_step++)
        {
            for (int vertical_step = 0; vertical_step < array_2d_i.GetLength(1); vertical_step++)
            {
                expression_stringified = array_2d_i[horizontal_step, vertical_step].ToString();
                max_expression_length =
                expression_stringified.Length > max_expression_length ?
                expression_stringified.Length : max_expression_length;
            }
        }//красота требует жертв, говорите?
        max_expression_length += 2;
        string strikethrough = new string('-',
        max_expression_length * (array_2d_i.GetLength(0)) +
        left_border.Length +
        right_border.Length +
        separator.Length * (array_2d_i.GetLength(0) - 1));
        WriteLine(strikethrough);
        for (int horizontal_step = 0; horizontal_step < array_2d_i.GetLength(0); horizontal_step++)
        {
            sup_arr_line = new string[array_2d_i.GetLength(0)];
            for (int vertical_step = 0; vertical_step < array_2d_i.GetLength(1); vertical_step++)
            {
                expression_stringified = array_2d_i[horizontal_step, vertical_step].ToString();
                sup_arr_line[vertical_step] = expression_stringified;
            }
            for (int normalize = 0; normalize < sup_arr_line.Length; normalize++)
            {
                sup_arr_line[normalize] = sup_arr_line[normalize].PadRight(max_expression_length);
            }
            sup_val_line = $"{left_border}{string.Join(separator, sup_arr_line)}{right_border}";
            WriteLine(sup_val_line);
        }
        WriteLine(strikethrough);
        return null!;
    }

    public dynamic summarize_lines(double[,] array_2d_i)
    {
        //ахаха :(
        string sup_val_line;
        double sum_buffer;
        string left_border = "| ", right_border = " |", separator = " | ",implication=" ==> ";
        string[] sup_arr_line;
        int max_expression_length = 0;
        string expression_stringified = String.Empty;
        for (int horizontal_step = 0; horizontal_step < array_2d_i.GetLength(0); horizontal_step++)
        {
            for (int vertical_step = 0; vertical_step < array_2d_i.GetLength(1); vertical_step++)
            {
                expression_stringified = array_2d_i[horizontal_step, vertical_step].ToString();
                max_expression_length =
                expression_stringified.Length > max_expression_length ?
                expression_stringified.Length : max_expression_length;
            }
        }
        max_expression_length += 2;
        string strikethrough = new string('-',
        max_expression_length * (array_2d_i.GetLength(0)) +
        left_border.Length +
        right_border.Length +
        separator.Length * (array_2d_i.GetLength(0) - 1));
        WriteLine(strikethrough);
        for (int horizontal_step = 0; horizontal_step < array_2d_i.GetLength(0); horizontal_step++)
        {
            sum_buffer=0.0;
            sup_arr_line = new string[array_2d_i.GetLength(0)];
            for (int vertical_step = 0; vertical_step < array_2d_i.GetLength(1); vertical_step++)
            {
                sum_buffer+=array_2d_i[horizontal_step, vertical_step];
                expression_stringified = array_2d_i[horizontal_step, vertical_step].ToString();
                sup_arr_line[vertical_step] = expression_stringified;
            }
            for (int normalize = 0; normalize < sup_arr_line.Length; normalize++)
            {
                sup_arr_line[normalize] = sup_arr_line[normalize].PadRight(max_expression_length);
            }
            sup_val_line = $"{left_border}{string.Join(separator, sup_arr_line)}{right_border}{implication}{sum_buffer}";
            WriteLine(sup_val_line);
        }
        WriteLine(strikethrough);
        return null!;
    }
    public dynamic get_value_by_indexes(int position_horizontal, int position_vertical,double[,] array_2d_i)
    {
        string output=$"Размерность массива не соответсвует запросу [{position_horizontal},{position_vertical}]";
        if (position_horizontal>array_2d_i.GetLength(0)||position_vertical>array_2d_i.GetLength(1))
        {
            return output;
        }
        output=$"Значение по адресу [{position_horizontal}, {position_vertical}]: {array_2d_i[position_horizontal,position_vertical]}";
        return output;
    }
    public dynamic main()
    {
        Clear();
        two_dimensional_array.todo(1);
        print_2d_array(array_2d_i: this.content_random_fractured_numbers);
        two_dimensional_array.todo(2);
        WriteLine(get_value_by_indexes(position_horizontal:1,position_vertical:100, array_2d_i:this.content_random_fractured_numbers));
        WriteLine(get_value_by_indexes(position_horizontal:0,position_vertical:0, array_2d_i:this.content_random_fractured_numbers));
        two_dimensional_array.todo(3);
        summarize_lines(array_2d_i:this.content_random_whole_numbers);

        return null!;
    }


}