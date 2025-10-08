using LeetCode.Problems.Easy;

namespace LeetCode.Tests.Easy;

public class TwoSumTests
{
    private readonly TwoSum _solution;

    public TwoSumTests()
    {
        _solution = new TwoSum();
    }

    [Fact]
    public void Example1_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] expected = { 0, 1 };

        // Act
        int[] result = _solution.Solution(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { 3, 2, 4 };
        int target = 6;
        int[] expected = { 1, 2 };

        // Act
        int[] result = _solution.Solution(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example3_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { 3, 3 };
        int target = 6;
        int[] expected = { 0, 1 };

        // Act
        int[] result = _solution.Solution(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}
