/*
 * @lc app=leetcode id=3640 lang=csharp
 *
 * [3640] Trionic Array II
 */

// @lc code=start
public class Solution {
    public long MaxSumTrionic(int[] nums) {
        int state = 0;
        long sum = 0L,
            result = long.MinValue,
            continueSum = 0L;

        for (int i = 1; i < nums.Length; i++)
        {
            if (state == 0)
            {
                if (nums[i] > nums[i - 1])
                {
                    sum = sum + nums[i] + nums[i - 1];
                    state = 1;
                }
            }
            else if (state == 1)
            {
                if (nums[i] > nums[i - 1])
                {
                    sum = Math.Max(sum + nums[i], nums[i] + nums[i - 1]);
                }
                else if (nums[i] == nums[i - 1])
                {
                    sum = 0L;
                    state = 0;
                }
                else
                {
                    sum += nums[i];
                    state = 2;
                }
            }
            else if (state == 2)
            {
                continueSum = 0;
                if (nums[i] < nums[i - 1])
                {
                    sum += nums[i];
                }
                else if (nums[i] == nums[i - 1])
                {
                    sum = 0L;
                    state = 0;
                }
                else
                {
                    sum += nums[i];
                    result = Math.Max(result, sum);
                    continueSum = continueSum + nums[i] + nums[i - 1];
                    state = 3;
                }
            }
            else
            {
                if (nums[i] > nums[i - 1])
                {
                    sum += nums[i];
                    result = Math.Max(result, sum);
                    continueSum = Math.Max(continueSum + nums[i], nums[i] + nums[i - 1]);
                }
                else if (nums[i] == nums[i - 1])
                {
                    sum = 0L;
                    state = 0;
                }
                else
                {
                    sum = continueSum + nums[i];
                    state = 2;
                }
            }
        }

        return result;
    }
}
// @lc code=end

