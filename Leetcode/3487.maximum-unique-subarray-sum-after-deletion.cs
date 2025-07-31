/*
 * @lc app=leetcode id=3487 lang=csharp
 *
 * [3487] Maximum Unique Subarray Sum After Deletion
 */

// @lc code=start
public class Solution {
    public int MaxSum(int[] nums) {
        HashSet<int> set = new ();
        int max = -100,
            result = 0;
        foreach (int num in nums)
        {
            max = Math.Max(max, num);
            if (num > 0)
            {
                set.Add(num);
            }
        }

        if (set.Count == 0)
        {
            return max;
        }

        foreach (int num in set)
        {
            result += num;
        }

        return result;
    }
}
// @lc code=end

