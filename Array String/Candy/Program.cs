namespace Candy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ratings = { 1, 2, 2 };
            Console.WriteLine(Candy(ratings));
        }


        public static int Candy(int[] ratings)
        {
            int[] candies = Enumerable.Repeat(1, ratings.Length).ToArray();

            


            for (int i = 0; i < candies.Length-1; i++)
            {
                if (ratings[i+1] > ratings[i])
                {
                    candies[i + 1] = candies[i] + 1;
                }
            }

            for (int i = candies.Length - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }


            return candies.Sum();
        }
    }
}