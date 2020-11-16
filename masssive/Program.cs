using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masssive
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            float average = 0; //среднее значение
            int evenElementArray = 0;
            int unEveneElementArray = 0;

            try
            {
                Console.Write("Введите размер массива: ");
                var size = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Введите значенние массива ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                int max = array[0];

                for (int i = 1; i < size; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                }
                Console.WriteLine("\nМаксимальное значение {0}", max);

                int min = array[0];

                for (int i = 1; i < size; i++)
                {
                    if (array[i] < min)
                        min = array[i];
                }
                Console.WriteLine("Минимальное значение {0}", min);

                for (int i = 0; i < size; i++)
                {
                    sum += array[i];
                    average = sum / size;
                    if (array[i] % 2 == 0)
                    {
                        array[i] = array[i] * size;
                        evenElementArray += array[i];
                    }
                    else
                    {
                        array[i] = array[i] + 3;
                        unEveneElementArray += array[i];
                    }
                }
                Console.WriteLine("\nСумма масива = {0}", sum);
                Console.WriteLine("Среднее значение = {0}", average);
                Console.WriteLine("\nПроизведение четных чисел на размер массива = {0}", evenElementArray);
                Console.WriteLine("Сумма неченых элементов увеличенных на 3 = {0}", unEveneElementArray);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
