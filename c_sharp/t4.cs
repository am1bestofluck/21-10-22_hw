using System;
using System.Diagnostics;
using System.Threading;
using static System.Console;
class big_data
{
    const int min_val_default = Int32.MinValue, max_val_default = Int32.MaxValue, size_default = 10000000;
    // const int min_val_default = 0, max_val_default = 1000, size_default = 10000000;
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
    public static void stack_overflow_wisdom()
{
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.BufferWidth));
    Console.SetCursorPosition(0, Console.CursorTop);
}
    public dynamic represent_main()
    {
        return this.body;
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
    protected static int[] convert_list_to_array(List<int> coll_i)
    {
        int len_supval=coll_i.Count;//а вдруг он его будет считать миллион раз если не объявить заранеее?
        int[] output= new int[len_supval];
        for (int push = 0; push < len_supval; push++)
        {
            output[push]=coll_i[push];
        }
        return output;
    }
    public dynamic matching_nested_cycle(int[] arr_inc, int[] arr_self)
    {
        WriteLine(@"Начинаем переборку вложенными циклами. Продолжительность при тестировании на БОЛЬШИХ объемах информации кошмарно долгая, ну или Я что-то не так делаю.
Прикрываем лавочку через минуту, выводим в консоль если есть совпадение.");
        Stopwatch nested_cycle = new Stopwatch();
        List<int> tmp_collection= new List<int>();
        int len_supval_oberved=arr_inc.Length,  len_supval_insider= arr_self.Length;
        int sorted_part=0,buffer=0;
        bool force_stop=false;
        nested_cycle.Start();
        WriteLine();
        for (int find_this = 0; find_this < len_supval_insider; find_this++)
        {
            Write('.');
            if (find_this%3==0) stack_overflow_wisdom();//:(
            for (int look_there = 0; look_there < len_supval_oberved; look_there++)
            {
                if (arr_self[find_this]==arr_inc[look_there])
                {
                    WriteLine($"Обнаружили совпадение элемента {arr_self[find_this]}");
                    tmp_collection.Add(arr_inc[look_there]);// это дальше перебросим в массив- вывод
                    buffer=arr_inc[sorted_part];
                    arr_inc[sorted_part]=arr_inc[look_there];
                    arr_inc[look_there]=buffer;//тут Мы переставляем выстрелившие элементы в начало списка
                    sorted_part++;//передвигаем позицию перемещения
                    // WriteLine(String.Join(", ",arr_inc));//для отладки
                    break;
                }
                if (nested_cycle.Elapsed.TotalSeconds>60)
                {
                    WriteLine();
                     WriteLine($"Обошли второй список, {find_this+1} раз за {((int)nested_cycle.Elapsed.TotalSeconds)} секунд.");
                     force_stop=true;
                    goto Loop_end;
                }
                
            }
           
        }
        Loop_end:
        nested_cycle.Stop();
        TimeSpan expected_horribly_long_waiting = nested_cycle.Elapsed;
        if (!force_stop) WriteLine($"Обнаружение совпадений через вложенные циклы заняло {((int)expected_horribly_long_waiting.TotalSeconds)} секунд.");
        int[] output=convert_list_to_array(tmp_collection);
        return output;
    }
    public dynamic matching_hash_sets(int[] arr_inc, int[] arr_self)
    {
        WriteLine(@"Начинаем переборку хешсетами... Условие одной минуты в силе,
 но здесь это похоже не понадобится");
        Stopwatch hash_set = new Stopwatch();
        hash_set.Start();
        HashSet<int> arr_inc_m =new HashSet<int>();
        HashSet<int> arr_self_m = new HashSet<int>();
        HashSet<int> output= new HashSet<int>();
        foreach (var item in arr_inc)
        {
            arr_inc_m.Add(item);
        }
        // arr_inc=new int[0];//ммммм, чистим память, потому что out of memory
        WriteLine($"Закончили хешировать первый массив. Прошло {((int)hash_set.Elapsed.TotalSeconds)} секунд");
        foreach (var item in arr_self)
        {
            arr_self_m.Add(item);
        }
        // arr_self=new int[0];
        WriteLine($"Закончили хешировать второй массив. Прошло {((int)hash_set.Elapsed.TotalSeconds)} секунд");
        output.UnionWith(arr_self_m); //(arr_self_m);
        output.IntersectWith(arr_inc_m);
        TimeSpan hash_set_cut_line=hash_set.Elapsed;
        WriteLine($"Обнаружение совпадений через хеш-сеты заняло {hash_set_cut_line.TotalSeconds} секунд.");
        hash_set.Stop();
        return output;


    }
}