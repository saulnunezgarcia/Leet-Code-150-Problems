namespace Integer_to_Roman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(1994));
        }

        public static string IntToRoman(int num)
        {
            string[] ones = {"","I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            string[] tens = { "","X","XX", "XXX","XL","L","LX","LXX","LXXX","XC"};
            string[] cents = { "","C", "CC", "CCC","CD","D","DC","DCC","DCCC","CM" };
            string[] thousands = {"","M","MM","MMM"};

            string number = thousands[num/1000] + cents[num%1000/100] + tens[num%100/10] + ones[num%10];
            return number;
        }
    }
}