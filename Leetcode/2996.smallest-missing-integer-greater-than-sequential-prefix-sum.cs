/*
 * @lc app=leetcode id=2996 lang=csharp
 *
 * [2996] Smallest Missing Integer Greater Than Sequential Prefix Sum
 */

// @lc code=start
public class Solution {
    public int MissingInteger(int[] nums) {
        bool[] exists = new bool[51];
        exists[nums[0]] = true;
        int total = nums[0],
            i = 1;
        while (i < nums.Length)
        {
            if (nums[i] != nums[i - 1] + 1)
            {
                break;
            }

            exists[nums[i]] = true;
            total += nums[i];
            i++;
        }

        if (total > 50)
        {
            return total;
        }
        
        while (i < nums.Length)
        {
            exists[nums[i++]] = true;
        }

        while (total <= 50 &&
            exists[total])
        {
            total++;
        }

        return total;
    }
}
// @lc code=end

