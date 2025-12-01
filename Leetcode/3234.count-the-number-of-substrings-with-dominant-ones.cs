/*
 * @lc app=leetcode id=3234 lang=csharp
 *
 * [3234] Count the Number of Substrings With Dominant Ones
 */

// @lc code=start
public class Solution {
    public int NumberOfSubstrings(string s) {
        int[] zeroPos = new int[s.Length + 1];
        zeroPos[0] = -1;
        int result = 0,
            totalZero = 1,
            totalOne = 0,
            zeros = 0,
            ones = 0;
        
        for (int r = 0; r < s.Length; r++)
        {
            if (s[r] == '0')
            {
                zeroPos[totalZero++] = r;
            }
            else
            {
                totalOne++;
                result += r - zeroPos[totalZero - 1];
            }

            for (zeros = 1; zeros < totalZero && zeros * zeros <= totalOne; zeros++)
            {
                ones = r - zeroPos[totalZero - zeros - 1] - zeros;
                if (zeros * zeros > ones)
                {
                    continue;
                }
                result += Math.Min(zeroPos[totalZero - zeros] - zeroPos[totalZero - zeros - 1],
                    ones - zeros * zeros + 1);
            }
        }

        return result;
    }
}
// @lc code=end

