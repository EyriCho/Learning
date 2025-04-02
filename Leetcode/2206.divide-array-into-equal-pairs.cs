/*
 * @lc app=leetcode id=2206 lang=csharp
 *
 * [2206] Divide Array Into Equal Pairs
 */

// @lc code=start
public class Solution {
    public bool DivideArray(int[] nums) {
        int[] counts = new int[501];
        int single = 0;

        foreach (int num in nums)
        {
            if (counts[num] == 0)
            {
                counts[num] = 1;
                single++;
            }
            else
            {
                counts[num] = 0;
                single--;
            }
        }

        return single == 0;
    }
}
// @lc code=end

