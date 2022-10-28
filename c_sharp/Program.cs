// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using static System.Console;
void basic()
{
    two_dimensional_array task1_3 = new two_dimensional_array(width_i: 5, height_i: 5);
    task1_3.main();

}
void extended()
{
    WriteLine("Рандомим массив длиной в половину int32");
    big_data t4_0 = new big_data();
    // WriteLine(String.Join(", ",t4_0.represent_main()));
    WriteLine("Рандомим массив длиной в почти int32");
    big_data t4_1 = new big_data(size_i:Int32.MaxValue /100*99);
    // WriteLine(String.Join(", ",t4_1.represent_main()));
    // big_data t4_1 = new big_data(min_val_i:10,max_val_i:11,size_i:50);
    WriteLine(@"Дома на заполнение на дефолтных настройках ушло 9 и 18 секунд,
на работе половинка даже не скомпиллировалось, зависло намертво.
Вот вам и цена алгоритмов, никаких сортировок не надо.");
    int[] nested_cycle_iteration=t4_0.matching_nested_cycle(arr_inc:t4_1.represent_main(),arr_self:t4_0.represent_main());
    
    string tmp=nested_cycle_iteration.Length==0? "В массивах совпадений не нашлось": $"{String.Join(", ",nested_cycle_iteration)}";
    WriteLine(tmp);
}
basic();
extended();