namespace Is_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string t = "abc";
            string s = "b";
            Console.WriteLine(IsSubsequence(s,t));
        }

        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) 
            { 
                return true; 
            }

            int count = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == s[count])
                {
                    count++;
                    if (count == s.Length)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}