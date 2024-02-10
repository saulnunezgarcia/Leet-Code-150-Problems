using System.Text.RegularExpressions;

namespace Valid_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Damosel, a poem? A carol? Or a cameo pale? (So mad!)";

            Console.WriteLine(IsPalindrome(s));
        }

        public static bool IsPalindrome(string s)
        {
            
            s = s.ToLower();

            Regex reg = new Regex("[]*'\",`_?&!#^@{()}[.;: -]");
            s = reg.Replace(s, string.Empty);

            if (s.Length == 0)
            {
                return true;
            }


            int start = 0;
            int end = s.Length-1;

            //race
            //ecar
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] == s[end])
                {
                  
                    end--;
                }
                else
                {
                    return false;                   
                }
            }

            return true;
        }
    }
}