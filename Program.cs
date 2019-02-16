using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_VALUE = 0;
            const int MAX_VALUE = 20;
            const int ARRAY_LENGHT = 10;
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < ARRAY_LENGHT; i++)
            {
                list.Add(random.Next(MIN_VALUE, MAX_VALUE));
            }
            
            for (int i = 0; i < ARRAY_LENGHT; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();

            int lastElement = ARRAY_LENGHT - 1;
            int secondMaxElement = lastElement;
            var sortList = list;
            sortList.Sort();

            for (int i = lastElement; i >= 0; i--)
            {
                if (sortList[secondMaxElement] > sortList[i])
                {
                    secondMaxElement = i;
                    break;
                }
            }

            for (int i = 0; i < ARRAY_LENGHT; i++)
            {
                if (list[i] == sortList[secondMaxElement])
                {
                    secondMaxElement = i;
                    break;
                }
            }

            Console.WriteLine($"Second max element = {secondMaxElement}");
            Console.WriteLine($"Value = {list[secondMaxElement]}");

            int sum = 0;
            for (int i = 0; i < ARRAY_LENGHT; i++)
            {
                if (i % 2 == 0) 
                {
                    sum += list[i];
                }
            }
            Console.WriteLine($"Sum = {sum}");


            Console.Read();
        }
    }
}
