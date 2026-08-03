using System.Text.Json;
using LeetCode.Problems.Medium;

public class GasStationTest
{
    private readonly GasStation gasStation = new();

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5, 1, 2 }, 3 },
            new object[] { new[] { 3, 3, 4 }, new[] { 3, 4, 4 }, -1 },
        };

    [Theory]
    [MemberData(nameof(TestData))]
    public void GasStation_DataDrive(int[] gas, int[] fuelNeededToReachNextStation, int expected)
    {
        var actual = gasStation.CanCompleteCircuit(gas, fuelNeededToReachNextStation);
        Assert.Equal(expected, actual);
    }
}
