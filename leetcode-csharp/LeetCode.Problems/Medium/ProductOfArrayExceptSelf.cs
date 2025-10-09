namespace LeetCode.Problems.Medium;

public class ProduceExceptSelfSolution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        // Bute force O(n²) time complexity, but the question asks for O(n) time
        // for (int i = 0; i < n; i++)
        // {
        //     var product = 1;
        //     for (int j = 0; j < n; j++)
        //     {
        //         if (i != j) product *= nums[j];
        //     }
        //     result[i] = product;
        // }

        // Create the products to the left of i
        result[0] = 1; // Nothing to the left
        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        // Go backwards and multiply by the products to the right
        var rightProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }
        return result;
    }
}
