/*
 * @lc app=leetcode id=3719 lang=csharp
 *
 * [3719] Longest Balanced Subarray I
 */

// @lc code=start
public class Solution {
    public int LongestBalanced(int[] nums) {
        int result = 0, r = 0,
            odd = 0, even = 0;
        HashSet<int> set = new ();
        for (int l = 0; l < nums.Length; l++)
        {
            set.Clear();
            r = l;
            odd = even = 0;
            while (r < nums.Length)
            {
                if (!set.Contains(nums[r]))
                {
                    if ((nums[r] & 1) == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                    set.Add(nums[r]);
                }
                if (odd == even)
                {
                    result = Math.Max(result, r - l + 1);
                }
                r++;
            }
        }

        return result;
    }
}
// @lc code=end

