namespace Length_of_Last_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "   fly me   to   the moon  ";

            Console.WriteLine(LengthOfLastWord(s));
        }

        public static int LengthOfLastWord(string s)
        {

            List<string> worldLength = new List<string>();

            for(int i = s.Length-1; i >=0; i--)
            {
                if (s[i] != ' ')
                {
                    worldLength.Add(s[i].ToString());

                    if(i != 0)
                    {
                        if (s[i - 1] == ' ')
                        {
                            return worldLength.Count;
                        }
                    }

                }
            }

            return worldLength.Count;
        }
    }
}