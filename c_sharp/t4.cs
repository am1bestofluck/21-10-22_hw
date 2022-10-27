using System;
using System.Diagnostics;
using System.Threading;
using static System.Console;
class big_data
{
    const int min_val_default = Int32.MinValue, max_val_default = Int32.MaxValue, size_default = Int32.MaxValue / 2;
    int min_val, max_val, size;
    int[] body;
    public big_data(int? min_val_i = null, int? max_val_i = null, int? size_i = null)
    {
        this.min_val = min_val_i.HasValue ? min_val_i!.Value : min_val_default;
        this.max_val = max_val_i.HasValue ? max_val_i!.Value : max_val_default;
        this.size = size_i.HasValue ? size_i!.Value : size_default;
        Stopwatch init = new Stopwatch();
        init.Start();
        this.body = randomize_content(min_val_i: this.min_val, max_val_i: this.max_val, size_i: this.size);
        init.Stop();
        TimeSpan well_it_isnt_too_hard_yet = init.Elapsed;
        WriteLine($"На создание массива ушло {well_it_isnt_too_hard_yet.Seconds} секунд.");

    }
    protected dynamic randomize_content(int min_val_i, int max_val_i, int size_i)
    {
        Random content = new Random();
        int[] output = new int[size_i];
        for (int declare_it = 0; declare_it < size_i; declare_it++)
        {
            output[declare_it] = content.Next(min_val_i,max_val_i);
        }
        return output;
    }
}
