namespace Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3,2,3};
            Console.WriteLine(MajorityElement(nums));
        }

        public static int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }
    }
}