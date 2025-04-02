/*
 * @lc app=leetcode id=2560 lang=csharp
 *
 * [2560] House Robber IV
 */

// @lc code=start
public class Solution {
    public int MinCapability(int[] nums, int k) {
        
        bool CanRob(int capability)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= capability)
                {
                    count++;
                    i++;
                }
            }
            return count >= k;
        }

        int min = int.MaxValue,
            max = 0,
            m = 0;
        foreach (int num in nums)
        {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        int result = max;
        while (min <= max)
        {
            m = min + ((max - min) >> 1);
            if (CanRob(m))
            {
                result = m;
                max = m - 1;
            }
            else
            {
                min = m + 1;
            }
        }

        return result;
    }
    }
// @lc code=end

