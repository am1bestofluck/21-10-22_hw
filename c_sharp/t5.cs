using static System.Console;
using System.Collections;
using System.Collections.Generic;

namespace t5
{
    public class Ring<T>// это звено цепи
    {
        public static void todo()
        {
            WriteLine("Создать односвязный список и развернуть");
        }
        public Ring(int content_i)
        {
            this.content=content_i;
        }
        public int content {get;set;} //это содержимое
        public Ring<int> Next {get;set;}// это адрес на следующее звено
    }
    public class Chain <Ring>//интернет предлагает наследовать ienumerable. Когда пойму тогда и унаследую=\
    {
        Ring<int> _head;//первый элемент
        Ring<int> _tail;// послендий элемент
        int _count;// всего элементов

        public void Add( int _ring_content)//ну вроде как это минимальный набор
        {
            Ring<int> ring = new Ring<int>(_ring_content);
            if (this._head==null)
            {
                this._head=ring;
                _tail=ring; q
            }
            else
            {
                _tail.Next=ring;
            }
            _count++;
        }

        public static void main()
        {
            WriteLine("qwe!");
            Random content = new Random();
            Chain<Ring<int>> linked_list= new Chain<Ring<int>>();
            for (int add_item = 0; add_item < 10; add_item++)
            {
                linked_list.Add( content.Next(0,100));
            }
            WriteLine();

        }
    }
}