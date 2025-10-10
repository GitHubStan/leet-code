namespace LeetCode.Problems.Medium;

public class GasStation
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var totalGasAvailable = gas.Sum();
        var totalGasRequired = cost.Sum();

        if (totalGasAvailable < totalGasRequired)
        {
            return -1;
        }

        var tank = 0;
        var startIndex = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            tank += gas[i] - cost[i];
            // if we don't have gas to get to the next station,
            // reset the tank and update the starting station.
            if (tank < 0)
            {
                tank = 0;
                startIndex = i + 1;
            }
        }

        // Since the problem states that there is only 1 solution
        // if we have only 1 valid startIndex in the array, then that
        // must be the solution.
        return startIndex < gas.Length ? startIndex : -1;
    }
}
