using System.Collections.Immutable;

namespace Product_of_Array_Except_Self
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,3,4 };
            int[] result = ProductExceptSelf(nums);

            Console.WriteLine(String.Join(",",result));

            

        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] numsMultiplied = Enumerable.Repeat(1,nums.Length).ToArray();
            int rightMultiplication = 1;
            int leftMultiplication = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                numsMultiplied[i] = rightMultiplication;
                rightMultiplication *= nums[i];

            }

            for (int i = nums.Length-1; i>=0; i--)
            {

                numsMultiplied[i] *= leftMultiplication;
                leftMultiplication *= nums[i];
                
            }

            return numsMultiplied;

        }


    }
}