namespace Jump_Game_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            Console.WriteLine(Jump(nums));
        }

        public static int Jump(int[] nums)
        {
            if (nums.Length <= 1) return 0;

            int jumps = 0;
            int currentEnd = 0;
            int furthestReach = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                furthestReach = Math.Max(furthestReach, i + nums[i]);


                if (i == currentEnd)
                {
                    jumps++;  
                    currentEnd = furthestReach;  

                    if (currentEnd >= nums.Length - 1) break;  
                }
            }

            return jumps;
        }
    }
}