namespace Remove_Duplicates_from_Sorted_Array_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            Console.WriteLine(RemoveDuplicates(nums));
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && count < 2)
                    {
                        count++;
                    }
                    else if (nums[i] == nums[j])
                    {
                        nums[j] = (int)Math.Pow(10, 5);
                    }

                }
                count = 0;
                Array.Sort(nums);
            }

            foreach (var element in nums)
            {
                if (element < (int)Math.Pow(10, 5))
                {
                    count++;
                }
            }
            return count;
        }
    }
}