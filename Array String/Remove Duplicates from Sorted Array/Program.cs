namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1,2};
            Console.WriteLine(RemoveDuplicates(nums));
        }

        public static  int RemoveDuplicates(int[] nums)
        {
            int i = 0;

            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j + 1] == nums[j])
                {
                    i++;
                    if (j == nums.Length - 2)
                    {
                        nums[j - i + 1] = nums[nums.Length - 1];
                    }
                }
                else
                {
                    nums[j - i] = nums[j];
                    if (j == nums.Length - 2)
                    {
                        nums[j - i + 1] = nums[nums.Length - 1];
                    }
                }
            }

            //Maximum value 

            int maxValue = nums.Max();

            return Array.IndexOf(nums, maxValue) + 1;
        }
    }
}