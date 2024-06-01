/*
 * @lc app=leetcode id=2441 lang=csharp
 *
 * [2441] Largest Positive Integer That Exists With Its Negative
 */

// @lc code=start
public class Solution {
    public int FindMaxK(int[] nums) {
        HashSet<int> set = new ();
        int result = -1;

        foreach (int num in nums)
        {
            if (set.Contains(num * -1))
            {
                result = Math.Max(result, Math.Abs(num));
            }
            else
            {
                set.Add(num);
            }
        }

        return result;
    }
}
// @lc code=end

