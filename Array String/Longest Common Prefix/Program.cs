using System.Diagnostics.Metrics;

namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "ab", "a" };
            string[] strsa = new string[] { "flos", "flow","fla" };
            Console.WriteLine(LongestCommonPrefix(strsa));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            int count = 0;
            int i = 0;
            bool flag = true;

            if (strs[0].ToString() == "")
            {
                return "";
            }

            string counter = strs[0][count].ToString();
            string prefix = ""; 


            while (flag)
            {
                if (strs[i][count].ToString() == counter && strs.Length > 1)
                {
                    i++;
                    count = 0;
                    flag = true;

                    if (i == strs.Length)
                    {
                        i = 0;
                        count++;
                        prefix += counter;
                        counter = strs[i][count].ToString();
                        
                    }
                }               
                else 
                {
                    flag = false;
                    
                    return prefix;
                }
            }

            return null;
        }
    }
}