/*
 * @lc app=leetcode id=189 lang=csharp
 *
 * [189] Rotate Array
 */

// @lc code=start
public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        if (k == 0)
            return;
        
        int start = 0, i = 0, prev = 0, cur = nums[0], count = 0;

        while (count < nums.Length)
        {
            prev = cur;
            i = i + k;
            if (i >= nums.Length)
                i -= nums.Length;
            cur = nums[i];
            nums[i] = prev;
            if (i == start)
            {
                i = ++start;
                cur = nums[i];
            }
            count++;
        }
    }
}
// @lc code=end

