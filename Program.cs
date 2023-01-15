using System;

namespace Two_Sums
{
    class Program
    {
        static int[] input3 = new int[]
        {
            3,2,4
        };

        static void Main(string[] args)
        {
            var twosum = TwoSum(input3,10); // result should be [1,2]
            Console.WriteLine($"REAL RESULT: [{twosum[0]}, {twosum[1]}]");
        }
        static public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++) //goes through array of numbers
            {
                int v1 = nums[i];
                Console.WriteLine($"number:{nums[i]}" + $" position: {i}" + " I LOOP");

                for (int j = 0; j < nums.Length; j++) //second loop going through second array
                {
                    int v2 = nums[j];
                    Console.WriteLine($"number:{nums[j]}" + $" position: {j}"+" J LOOP");

                    if (target == v1+v2 && i != j) //how to say that is target is equal to v1 + v2 return an array of those positions
                    {
                        nums = new int[]{i,j};
                    }

                }
            }
            return nums;
        }
    }
}
