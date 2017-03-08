using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingNumberARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 14, 8, 1, 16, 2, 20, 7 };

            for (int x = 0; x < array.Length; x++)
            {
                for (int i = 0; i < (array.Length - 1); i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }

                }
            }
            for (int write = 0; write < array.Length; write++)
            {
                Console.WriteLine(array[write]);
            }
            Console.ReadLine();
        }
    }
}
