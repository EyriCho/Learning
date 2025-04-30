/*
 * @lc app=leetcode id=3375 lang=csharp
 *
 * [3375] Minimum Operations to Make Array Values Equal to K
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums, int k) {
        int[] array = new int[101];
        foreach (int num in nums)
        {
            if (num < k)
            {
                return -1;
            }
            array[num] = 1;
        }

        int result = 0;
        for (int i = k + 1; i < array.Length; i++)
        {
            result += array[i];
        }
        return result;
    }
}
// @lc code=end

