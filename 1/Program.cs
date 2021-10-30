using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            int sum=0;
            int max =0;
            int find;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
                Console.WriteLine(array[i]);
                sum += array[i];
                find = array[i];
                if (find > max)
                {
                    max = find;
                }
            }

            Task taskSum = new Task(() => Console.WriteLine($"Сумма всех чисел массива равна: {sum}")) ;
            Task taskMax = new Task(() => Console.WriteLine($"Максимальное число равно: {max}")) ;
            taskSum.Start();
            taskMax.Start();

            Console.ReadKey();
        }
    }
}
