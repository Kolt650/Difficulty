using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вычислите асимптотическую сложность функции из примера ниже

namespace Difficulty
{
    class Program
    {

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;                                                    //O(1)
            for (int i = 0; i < inputArray.Length; i++)                     //O(N)
            {   
                for (int j = 0; j < inputArray.Length; j++)                 //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++)             //O(N)
                    {
                        int y = 0;                                          //O(1)

                        if (j != 0)                                         
                        {
                            y = k / j;                                      //O(1)
                        }

                        sum += inputArray[i] + i + k + j + y;               //O(5)
                    }
                }
            }

            return sum;                                                     //O(1)
        }

        static void Main(string[] args)
        {
            //Сложность O(N^2)
        }
    }
}
