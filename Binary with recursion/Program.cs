using System;

namespace Binary_with_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 2, 7, 8, 9,10, 13, 17,19, 21 };
            //binarySearch(numArray, 7);
            Console.WriteLine("This is your arry: ");
            foreach (var item in numArray)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("\n" + binarySearch(numArray, 7));
            Console.WriteLine(binarySearch(numArray, 15));
        }

        public static dynamic binarySearch(int[] numArray, int target)
        {
            return binarySearchHealper(numArray,target, 0, numArray.Length - 1);
        }
        public static dynamic binarySearchHealper(int[] numArray, int target, int left, int right)
        {
            if(left > right)
            {
                return false;
            }

            int mid = Convert.ToInt32((left + right) / 2);
            if (target == numArray[mid])
            {
                return mid;
            }
            else if (target < numArray[mid])
            {
                return binarySearchHealper(numArray, target, left, mid - 1);
            }
            else
            {
                return binarySearchHealper(numArray, target, mid + 1, right);
            }
        }
    }
}
