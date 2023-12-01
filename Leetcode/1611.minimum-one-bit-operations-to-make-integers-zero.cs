/*
 * @lc app=leetcode id=1611 lang=csharp
 *
 * [1611] Minimum One Bit Operations to Make Integers Zero
 */

// @lc code=start
public class Solution {
    public int MinimumOneBitOperations(int n) {
        bool flag = true;
        long mask = 1L << 31;
        long result = 0;

        while (mask > 0)
        {
            if ((n & mask) > 0)
            {
                if (flag)
                {
                    result += (mask << 1) - 1;
                }
                else
                {
                    result -= (mask << 1) - 1;
                }

                flag = !flag;
            }

            mask >>= 1;
        }

        return (int)result;
    }
}
// @lc code=end

