using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class FindingNumbers
    {
        public (int min, int max) FindingLargestAndSmallestNumber(int[] array)
        {
            if(array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or zero");
            }
            int min = array[0];
            int max = array[0];

            foreach(int num in array)
            {
                if(num < min)
                {
                    min = num;
                }
                if(num > max)
                {
                    max = num;
                }
            }
            return (min, max);
        }

        public (int secondMin, int secondMax) FindingSecondLargestAndSecondSmallestNumber(int[] array)
        {
            if (array == null || array.Length == 0 || array.Length < 2)
            {
                throw new ArgumentException("Array must not be null or zero or less than 2 elements");
            }
            int min = int.MaxValue, secondMin = int.MaxValue;
            int max = int.MinValue, secondMax = int.MinValue;

            foreach (int num in array)
            {
                //Finding the second minimum number
                if (num < min)
                {
                    secondMin = min;
                    min = num;
                }
                else if(num <= secondMin && num != min)
                {
                    secondMin = num;
                }

                //finding the second largest number
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if(num >= secondMax && num != max)
                {
                    secondMax = num;
                }
            }

            if(secondMin == int.MaxValue && secondMax == int.MinValue)
            {
                throw new InvalidOperationException("No valid second minimum and maximum found");
            }
            return (secondMin, secondMax);
        }

        public (int secondMin, int secondMax) FindingThirdLargestAndThirdSmallestNumber(int[] array)
        {
            if (array == null || array.Length == 0 || array.Length < 3)
            {
                throw new ArgumentException("Array must not be null or zero or less than 3 elements");
            }
            int min = int.MaxValue, secondMin = int.MaxValue, thirdMin = int.MaxValue;
            int max = int.MinValue, secondMax = int.MinValue, thirdMax = int.MinValue;

            foreach (int num in array)
            {
                //Finding the second minimum number
                if (num < min)
                {
                    thirdMin = secondMin;
                    secondMin = min;
                    min = num;
                }
                else if (num <= secondMin && num != min)
                {
                    thirdMin = secondMin;
                    secondMin = num;
                }
                else if (num <= thirdMin && num != secondMin && num != min)
                {
                    thirdMin = num;
                }

                //finding the second largest number
                if (num > max)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = num;
                }
                else if (num >= secondMax && num != max)
                {
                    thirdMax = secondMax;
                    secondMax = num;
                }
                else if (num >= thirdMax && num != secondMax && num != max)
                {
                    thirdMax = num;
                }
            }

            if (thirdMin == int.MaxValue && thirdMax == int.MinValue)
            {
                throw new InvalidOperationException("No valid third minimum and maximum found");
            }
            return (thirdMin, thirdMax);
        }

        public void SortArrayAsc(int[] array)
        {
            int n = array.Length;

            for(int i = 0; i < n-1; i++)
            {
                for(int j=0; j< n-1-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

        }

        public void SortArrayDesc(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void MissingNumber(int[] numbers)
        {
            Array.Sort(numbers);
            int count = numbers[0];
            HashSet<int> unique = new HashSet<int>();
            foreach (int num in numbers)
            {
                if(num != count)
                {
                    Console.Write($"Missing Number is {count}");
                    break;
                }
                unique.Add(num);
                count++;
            }
        }
    }
}
