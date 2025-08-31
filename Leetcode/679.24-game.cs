/*
 * @lc app=leetcode id=679 lang=csharp
 *
 * [679] 24 Game
 */

// @lc code=start
public class Solution {
    public bool JudgePoint24(int[] cards) {
        bool Dfs(double[] nums)
        {
            if (nums.Length == 1)
            {
                return Math.Abs(nums[0] - 24D) < 0.000001;
            }

            double[] next = new double[nums.Length - 1];
            int idx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    idx = 0;
                    for (int k = 0; k < nums.Length; k++)
                    {
                        if (k != i && k != j)
                        {
                            next[idx++] = nums[k];
                        }
                    }

                    next[idx] = nums[i] + nums[j];
                    if (Dfs(next))
                    {
                        return true;
                    }

                    next[idx] = nums[i] * nums[j];
                    if (Dfs(next))
                    {
                        return true;
                    }

                    next[idx] = nums[i] - nums[j];
                    if (Dfs(next))
                    {
                        return true;
                    }

                    next[idx] = nums[j] - nums[i];
                    if (Dfs(next))
                    {
                        return true;
                    }

                    if (nums[i] > 0.000001)
                    {
                        next[idx] = nums[j] / nums[i];
                        if (Dfs(next))
                        {
                            return true;
                        }
                    }

                    if (nums[j] > 0.000001)
                    {
                        next[idx] = nums[i] / nums[j];
                        if (Dfs(next))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        double[] array = new double[4];
        for (int c = 0; c < 4; c++)
        {
            array[c] = cards[c];
        }
        return Dfs(array); 
    }
}
// @lc code=end

