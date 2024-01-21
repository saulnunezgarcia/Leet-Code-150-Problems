namespace Merge_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j = 0;

            while (m + j < m + n)
            {
                nums1[m + j] = nums2[j];
                j++;
            }

            for (int i = 0; i < m + n - 1; i++)
            {
                if (nums1[i + 1] < nums1[i])
                {
                    int k = nums1[i + 1];
                    nums1[i + 1] = nums1[i];
                    nums1[i] = k;
                    i = -1;
                }
            }
        }
    }
}