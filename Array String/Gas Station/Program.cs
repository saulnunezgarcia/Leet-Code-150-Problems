namespace Gas_Station
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gas = { 5,1,2,3,4};
            int[] cost = { 4,4,1,5,1};
            Console.WriteLine(CanCompleteCircuit(gas,cost));
        }

        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int gasIndex = 0;
            int costIndex = 0;
            bool around = false;
            int tank = 0;
            int i = 0;
            int valueDifference = 0;

            for(; i < gas.Length; i++)
            {
                
                if (gas[i] > cost[i] && gas[i] - cost[i] > valueDifference)
                {
                    valueDifference = gas[i] - cost[i];
                    gasIndex = i;
                    costIndex = i;
                }
            }

            tank = gas[gasIndex];

            while (!around)
            {
                if(gasIndex == gas.Length-1)
                {
                    gasIndex = 0;
                }
                else
                {
                    gasIndex++;
                }

                tank = tank - cost[costIndex] + gas[gasIndex];

                if (gasIndex == gas.Length - 1)
                {
                    gasIndex = 0;
                }
                else
                {
                    gasIndex++;
                }

                if (tank >= gas[gasIndex] )
                {
                    around = false;
                    gasIndex--;
                }
                else
                {
                    return -1;
                    break;
                    
                }

                costIndex++;

                if (costIndex == cost.Length)
                {
                    costIndex = 0;
                }

                if (gasIndex == i)
                {
                    around = true;
                    return gasIndex;
                    break;
                    
                }
                
                
            }

            return 0;
        }
    }
}