<details><summary><b>Задача 1. Задаем два огромных массива (желательно больше 1млр) A и В. Нужно найти какие значения из A входят в массив B.</b></summary>

<details><summary>Спецификация</summary>
Есть несколько варианттов решения.
<ul>
<li>вариант - сделать два вложенных цикла для поиска</li>
<li>отсортировать массив B (бинарной сортировкой) и бинарный поиском искать эл-ты из A в B </li>
<li>Использовать Hashset для B и один цикл for.</li>
</ul>
После реализации сравнить одним из способов:
<ul><li> через класс StopWatch (https://learn.microsoft.com/ru-ru/dotnet/api/system.diagnostics.stopwatch?view=net-6.0)</li><li> самый сложный вариант с помощью https://benchmarkdotnet.org/articles/overview.html </li></ul> Посчитать в ручную сложность алгоритма.
</details>
<details><summary>...hf!</summary>
Ну во первых у нас будет два экземпляра класса bigdata.
В конструкторе принимаем размерность и пределы, <i>это же не сложно?</i><br>
Объект на выходе из конструктора- здоровущий массив например интов.<br>
Варианты реализаций будут методами.<br>
Каждый метод принимает на вход другой стандартный массив? <br>
Каждый метод выводит массив совпавших значений.<br>
Каждый метод сначала создаёт копию входящего массива потому что совпадения в копии входящего массива Мы будем заменять на нулл.<br>
Соответственно, метод первый это:<br>
для каждого значения из "себя", пройтись по входящему массиву и когда найдём совпадение- заменить по индексу входящего массива на нулл, в вывод добавить само значение и прервать вложенный цикл<br>
Второй метод:<br>
Сюрприз-сюрприз, Мы их оба сортируем. <i>Разобраться в бинарщине.</i> Дальше тоже идём по методичке, алгоритм бинарной сортировки переизобретать не надо ._. .<br>
Третий метод:<br>
Что это. Сначала упасть в теорию =\
</details>
</details>
