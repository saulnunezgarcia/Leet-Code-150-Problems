namespace Reverse_Words_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Te amo Zazil";

            Console.WriteLine(ReverseWords(s));
        }

        public static string ReverseWords(string s)
        {
            string word = "";
            string backwardWord = "";
            List<string> words = new List<string>();

            for(int i = 0; i<s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    word += s[i];
                }
                if(word != "" && (s[i] == ' ' || i == s.Length-1 ) )
                {
                    words.Add(word);
                    word = "";
                }
            }

           

            for(int i = words.Count-1; i >= 0; i--)
            {
                backwardWord += words[i] + ' ';
                if(i == 0)
                {
                    backwardWord = backwardWord.Remove(backwardWord.Length-1);
                }
            }

            return backwardWord;
        }
    }
}