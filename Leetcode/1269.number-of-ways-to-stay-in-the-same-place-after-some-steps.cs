/*
 * @lc app=leetcode id=1269 lang=csharp
 *
 * [1269] Number of Ways to Stay in the Same Place After Some Steps
 */

// @lc code=start
public class Solution {
    public int NumWays(int steps, int arrLen) {
        if (steps == 1 || arrLen == 1)
        {
            return 1;
        }

        var array = new long[arrLen];
        array[0] = array[1] = 1L;
        for (int s = 1; s < steps; s++)
        {
            int max = Math.Min(s + 1, arrLen - 1);

            var temp = new long[max + 2];
            for (int i = 0; i <= max; i++)
            {
                if (i == 0)
                {
                    temp[i] = (array[0] + array[1]) % 1_000_000_007L;
                }
                else if (i == max)
                {
                    temp[i] = (array[max - 1] + array[max]) % 1_000_000_007L;
                }
                else
                {
                    temp[i] = (array[i - 1] + array[i] + array[i + 1]) % 1_000_000_007L;
                }
            }
            array = temp;
        }

        return (int)array[0];
    }
}
// @lc code=end

