namespace LeetCode.Problems.Easy;

/// <summary>
/// LeetCode Problem #1: Two Sum
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// </summary>
public class TwoSum
{
    /// <summary>
    /// Approach: Hash Map (Dictionary)
    /// - Iterate through the array once
    /// - For each element, check if (target - current element) exists in the hash map
    /// - If found, return the indices
    /// - Otherwise, store the current element and its index in the hash map
    /// Time Complexity: O(n)
    /// Space Complexity: O(n)
    /// </summary>
    public int[] Solution(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        throw new ArgumentException("No solution found");
    }
}
