namespace Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string haystack = "leetcode";
            string needle = "leeto";
            Console.WriteLine(StrStr(haystack,needle));
        }

        public static int StrStr(string haystack, string needle)
        {
            int windowSize = needle.Length;

            for (int i = 0; i <= haystack.Length-windowSize; i++)
            {
                if (haystack.Substring(i, windowSize) == needle)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}