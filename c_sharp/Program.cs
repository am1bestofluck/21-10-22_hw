// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using static System.Console;
void basic()
{
    two_dimensional_array task1_3 = new two_dimensional_array(width_i: 5, height_i: 5);
    task1_3.main();

}

void extended1()
{
    
    big_data t4_0 = new big_data();
    big_data t4_1 = new big_data();
    WriteLine(@"Дома на заполнение на дефолтных настройках ушло 9 и 18 секунд,
на работе половинка даже не скомпиллировалось, зависло намертво.
Вот вам и цена алгоритмов, никаких сортировок не надо.");
    int[] nested_cycle_iteration = t4_0.matching_nested_cycle(arr_inc: t4_1.represent_main(), arr_self: t4_0.represent_main());
    int estimated_shortcut_lenght=String.Join(", ", nested_cycle_iteration).Length>50? 50: String.Join(", ", nested_cycle_iteration).Length;
    string clearly_I_have_too_much_time= nested_cycle_iteration.Length==1? "...":"";
    string tmp = nested_cycle_iteration.Length == 0 ? "В массивах совпадений не нашлось" : @$"Нашлось {nested_cycle_iteration.Length} совпадений. 
Например: {String.Join(", ", nested_cycle_iteration).Substring(0,estimated_shortcut_lenght)}{clearly_I_have_too_much_time}";
    WriteLine(tmp);
    HashSet<int> hash_set_match = t4_0.matching_hash_sets(arr_inc: t4_1.represent_main(), arr_self: t4_0.represent_main());
    clearly_I_have_too_much_time= hash_set_match.Count >1? "":"...";
    string tmp1 = hash_set_match.Count == 0 ? "В массивах совпадений не нашлось" :
     @$"Нашлоcь {hash_set_match.Count} совпадений, например {String.Join(", ", hash_set_match).Substring(0, 50)}{clearly_I_have_too_much_time}";
    WriteLine(tmp1);



}

void extended2()
{
    WriteLine("Не знаю, не знаю - в одно рыло осваивать такой контент это довольно спорный ход.");
    // t5.Ring<int> qwe= new t5.Ring<int>(0);
    t5.Chain<t5.Ring<int>>.main();
}

// basic();
// extended1();
extended2();