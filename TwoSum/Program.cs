// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 5, 11 };
            int target = 10;
            int[] answer = TwoSum(numbers, target);
            PrintArray(answer);
        }



        public static int[] TwoSum(int[] nums, int target)
        {
            int[] numbers = nums;
            int[] answer = new int[2];
            bool found = false;

            for (int i = (nums.Length-1); i > 0; i--)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    
                    if ((nums[i] + nums[j]) == target)
                    {
                        found = true;
                        answer[0]=j;
                        answer[1]=i;
                        break;

                    }

                    if (found) { break; }   
                }
            }
            return answer;           
        }


        public static void PrintArray(int[] nums)
        {
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
