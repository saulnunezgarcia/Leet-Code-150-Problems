namespace Trapping_Rain_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 4,2,3};
            Console.WriteLine(Trap(height));
        }

        public static int Trap(int[] height)
        {
            int minWater = height[0];
            int container = 0;
            int waterCounter = 0;
            int lastPosition = 0;

            for (int i = 0; i<height.Length; i++)
            {
                if (minWater <= height[i])
                {
                    minWater = height[i];
                    waterCounter += container;
                    container = 0;
                    lastPosition = i;
                }
                else
                {
                    container += minWater - height[i];
                }
            }

            if(container != 0)
            {
                container = 0;
                minWater = height[height.Length - 1];
                for (int i = height.Length-1; i>= lastPosition; i--)
                {
                    if (minWater <= height[i])
                    {
                        minWater = height[i];
                        waterCounter += container;
                        container = 0;
                    }
                    else
                    {
                        container += minWater - height[i];
                    }

                }
            }

            return waterCounter;
        }
    }
}