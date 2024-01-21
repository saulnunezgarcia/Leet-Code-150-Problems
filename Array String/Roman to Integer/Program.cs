namespace Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanToInt = new Dictionary<char, int>();

            romanToInt.Add('I', 1);
            romanToInt.Add('V', 5);
            romanToInt.Add('X', 10);
            romanToInt.Add('L', 50);
            romanToInt.Add('C', 100);
            romanToInt.Add('D', 500);
            romanToInt.Add('M', 1000);

            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int value = romanToInt[s[i]];

                if (i != s.Length - 1 && (romanToInt[s[i + 1]] > value))
                {
                    number -= value;
                }
                else
                {
                    number += value;
                }


            }

            return number;
        }
    }
}