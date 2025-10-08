/**
 * LeetCode Problem #1: Two Sum
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 * You may assume that each input would have exactly one solution, and you may not use the same element twice.
 */

/**
 * Approach: Hash Map (Map)
 * - Iterate through the array once
 * - For each element, check if (target - current element) exists in the hash map
 * - If found, return the indices
 * - Otherwise, store the current element and its index in the hash map
 * Time Complexity: O(n)
 * Space Complexity: O(n)
 *
 * @param nums - Array of integers
 * @param target - Target sum
 * @returns Array containing the indices of the two numbers
 */
export function twoSum(nums: number[], target: number): number[] {
    const map = new Map<number, number>();

    for (let i = 0; i < nums.length; i++) {
        const complement = target - nums[i];

        if (map.has(complement)) {
            return [map.get(complement)!, i];
        }

        map.set(nums[i], i);
    }

    throw new Error('No solution found');
}
