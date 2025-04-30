/*
 * @lc app=leetcode id=2799 lang=csharp
 *
 * [2799] Count Complete Subarrays in an Array
 */

// @lc code=start
public class Solution {
    public int CountCompleteSubarrays(int[] nums) {
        int[] slot = new int[2001];
        int count = 0,
            l = 0,
            result = 0;
        foreach (int num in nums)
        {
            if (slot[num] == 0)
            {
                count++;
            }
            slot[num]++;
        }

        Array.Fill(slot, 0);
        for (int r = 0; r < nums.Length; r++)
        {
            if (slot[nums[r]] == 0)
            {
                count--;
            }
            slot[nums[r]]++;

            while (count == 0)
            {
                if (slot[nums[l]] == 1)
                {
                    count++;
                }
                slot[nums[l]]--;
                l++;
            }

            result += l;
        }

        return result;
    }
}
// @lc code=end

