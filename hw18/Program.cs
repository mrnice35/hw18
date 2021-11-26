using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();//создаем новый список значений
            list.Add(1);//добавляем значения в список
            list.Add(2);
            list.Add(3);
            int[] array = new int[3] { 4, 5, 6 };//создаем массив целый чисел (коллекцию)
            list.AddRange(array);//добавляем массив  в список
            list.RemoveAt(3);//удаляем из списка элемент с 3 позиции
            list.Reverse();//выполним реверс(развернем элементы в обратном порядке)
            for (int i=0;i<list.Count;i++)// перебор элементов циклом for
            {
                list[i]++;//увеличиваем каждый элемент на еденицу
            }
            foreach (int i in list)// перебираем элеенты
            {
                Console.WriteLine(i);//выводим элементы
            }
            Console.ReadKey();


        }
    } 
}
