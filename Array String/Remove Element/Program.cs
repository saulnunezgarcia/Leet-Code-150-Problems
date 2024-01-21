namespace Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3, 2, 2, 3};
            int val = 3;
            Console.WriteLine(RemoveElement(nums,val));
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;

            foreach (var element in nums)
            {
                if (element != val)
                {
                    nums[i] = element;
                    i++;
                }
            }
            return i;
        }
    }
}