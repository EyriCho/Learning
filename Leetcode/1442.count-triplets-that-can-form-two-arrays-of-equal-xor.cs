/*
 * @lc app=leetcode id=1442 lang=csharp
 *
 * [1442] Count Triplets That Can Form Two Arrays of Equal XOR
 */

// @lc code=start
public class Solution {
    public int CountTriplets(int[] arr) {
        int result = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if ((arr[j] ^ arr[i]) == 0)
                {
                    result += i - j;
                }
                arr[j] ^= arr[i];
            }
        }

        return result;
    }
}
// @lc code=end

