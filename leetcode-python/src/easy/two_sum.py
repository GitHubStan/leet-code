"""
LeetCode Problem #1: Two Sum
Given an array of integers nums and an integer target, return indices of the
two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may
not use the same element twice.
"""

from typing import List


def two_sum(nums: List[int], target: int) -> List[int]:
    """
    Approach: Hash Map (Dictionary)
    - Iterate through the array once
    - For each element, check if (target - current element) exists in the hash map
    - If found, return the indices
    - Otherwise, store the current element and its index in the hash map

    Time Complexity: O(n) - single pass through the array
    Space Complexity: O(n) - hash map storage

    Args:
        nums: List of integers
        target: Target sum to find

    Returns:
        List containing indices of the two numbers that add up to target

    Raises:
        ValueError: If no solution is found
    """
    num_map = {}

    for i, num in enumerate(nums):
        complement = target - num

        if complement in num_map:
            return [num_map[complement], i]

        num_map[num] = i

    raise ValueError("No solution found")
