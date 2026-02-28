/*
 * @lc app=leetcode id=868 lang=csharp
 *
 * [868] Binary Gap
 */

// @lc code=start
public class Solution {
    public int BinaryGap(int n) {
        int result = 0,
            prev = -1,
            curr = 0;

        while (n > 0)
        {
            if ((n & (1 << curr)) > 0)
            {
                if (prev != -1)
                {
                    result = Math.Max(result, curr - prev);
                }

                prev = curr;
                n &= ~(1 << curr);
            }
            curr++;
        }

        return result;
    }
}
// @lc code=end

