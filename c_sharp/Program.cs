using static System.Console;
void basic()
{
    two_dimensional_array task1_3 = new two_dimensional_array(
        rows: two_dimensional_array.validate_input("дай число строк пож"),
        columns: two_dimensional_array.validate_input("дай число колонок пож"));
    task1_3.main();

}
basic();
