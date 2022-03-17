using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Array
{
    public static class HomeworkArray
    {
        public static int CheckArray(int[] myArray)
        {
            
            int minValue = myArray[0];

            if (myArray.Length < 0)
            {
                throw new Exception("");
            }

            for (int i = 1; i < myArray.Length; i++)
            {

                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            return minValue;

        }
        public static int FindTheMaximumElementOfAnArray(int[] myArray)
        {          
            int maxValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {

                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }
            }
            return maxValue;
        }

        public static int FindMinTheIndex(int[] array)
        {            
            int minValue = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue=array[i];
                    index = i;
                }

            }
            return index;
        }

        public static int FindMaxTheIndex(int[] array)
        {         
            int maxValue = array[0];
            int result = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    result = i;
                }

            }
            return result;
        }

        public static int CalculateTheSumOfArrayElements(int[] array)
        {     
            int sum = 0;


            for (int i = 1; i < array.Length; i += 2)
            {

                sum = sum + array[i];
                int tmp = sum;
            }
            return sum;
        }
        public static int[] ReverseAnArray(int[] array)
        {

            int[] result = Copy(array);


            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = result[i];
                result[i] = result[result.Length - (1 + i)];
                result[result.Length - (1 + i)] = tmp;

            }
            return result;

        }

        public static int[] Copy(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }

        public static int[] GenerateRandom(int lenght, int min = -100, int max = 100)
        {
            if (lenght < 0)
            {
                throw new Exception("lenght mast be >=0");
            }

            Random random = new Random();
            int[] array = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                array[i] = random.Next(min, max + 1);
            }

            return array;
        }

        public static void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static int CountTheNumberOfOddElementsInAnArray(int[] result)
        {
            
            int sum = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] % 2 != 0)
                {
                    sum++;
                }

            }
            return sum;
        }

        public static int[] SwapTheFirstAndSecondHalfOfAnArray(int[] array)
        {
            int[] result = Copy(array); 

            int n = result.Length / 2;
            int step = n + result.Length %2;

            for (int i=0;i<n;i++)
            {
                int tmp = result[i];
                result[i] = result[i+step];
                result[i+step]=tmp;
            }
            return result;
           
        }
        public static int[] SortArrayByAge(int[] result)
        {
            


            for (int i = 0; i < result.Length; i += 1)
            {
                for (int j = 1 + i; j < result.Length; j++)
                    if (result[j] < result[i])
                    {
                        int c = result[i];
                        result[i] = result[j];
                        result[j] = c;

                    }

            }
            return result;

        }
        public static int[] SortArrayInDescendingOrder(int[] result)
        {          
          

            for (int i = 1; i < result.Length; i++) 
            {
               
                int crnt = i;
                while (crnt!=0 && result[crnt - 1]< result[crnt])
                {
                    int tmp = result[crnt];
                    result[crnt] = result[crnt - 1];
                    result[crnt - 1] = tmp;
                    crnt--;
                }
               

            }

            return result;
            
        }

    }
}

