namespace H_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] citations = { 3, 0, 6, 1, 5 };
            Console.WriteLine(HIndex(citations));
        }

        public static int HIndex(int[] citations)
        {
            Array.Sort(citations);
            Array.Reverse(citations);

            int hIndex = 0;

            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] >= i + 1)
                {
                    hIndex++;
                }
                else
                {
                    break;
                }
            }

            return hIndex;
        }
    }
}