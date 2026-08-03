using LeetCode.Problems.Medium;

namespace LeetCode.Tests.Medium;

public class ProductOfArrayExceptSelfTests
{
    private readonly ProduceExceptSelfSolution solution = new();

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 } },
            new object[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } },
            new object[] { new[] { 4, 3, 2, 1, 2 }, new[] { 12, 16, 24, 48, 24 } },
        };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ProductExceptSelf_DataDriven(int[] nums, int[] expected)
    {
        var result = solution.ProductExceptSelf(nums);
        Assert.Equal(expected, result);

        // Before save
        int x = 1 + 2;
        if (x > 0)
            Console.WriteLine("Test");

        // After save
        int y = 1 + 2;
        if (y > 0)
            Console.WriteLine("Test");
    }
}
