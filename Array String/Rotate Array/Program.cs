namespace Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        }

        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; // Handle cases where k is larger than array length

            Reverse(nums, 0, n - 1); // Reverse the entire array
            Reverse(nums, 0, k - 1); // Reverse the first k elements
            Reverse(nums, k, n - 1);

        }

        private static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}