namespace Jump_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            Console.WriteLine(CanJump(nums));
        }

        public static bool CanJump(int[] nums)
        {
            int maxReach = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxReach) return false;

                maxReach = Math.Max(maxReach, i + nums[i]);

                if (maxReach >= nums.Length - 1) return true;
            }
            return false;
        }
    }
}