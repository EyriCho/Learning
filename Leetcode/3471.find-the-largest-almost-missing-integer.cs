/*
 * @lc app=leetcode id=3471 lang=csharp
 *
 * [3471] Find the Largest Almost Missing Integer
 */

// @lc code=start
public class Solution {
    public int LargestInteger(int[] nums, int k) {
        if (k == nums.Length)
        {
            return nums.Max();
        }
        else if (k == 1)
        {
            int[] counts = new int[51];
            foreach (int num in nums)
            {
                counts[num]++;
            }

            for (int i = 50; i >= 0; i--)
            {
                if (counts[i] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        int a = nums[0],
            b = nums[^1];
        if (a == b)
        {
            return -1;
        }
        
        for (int i = nums.Length - 2; i > 0; i--)
        {
            if (nums[i] == a)
            {
                a = -1;
            }
            if (nums[i] == b)
            {
                b = -1;
            }
        }
        
        return Math.Max(a, b);
    }
}
// @lc code=end

