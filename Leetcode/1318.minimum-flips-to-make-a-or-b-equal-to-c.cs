/*
 * @lc app=leetcode id=1318 lang=csharp
 *
 * [1318] Minimum Flips to Make a OR b Equal to c
 */

// @lc code=start
public class Solution {
    public int MinFlips(int a, int b, int c) {
        int result = 0;

        for (int i = 0; i < 32; i++)
        {
            int pa = (a >> i) & 1,
                pb = (b >> i) & 1,
                pc = (c >> i) & 1;
            
            if ((pa | pb) == pc)
            {
                continue;
            }

            if (pc == 1)
            {
                result += 1;
            }
            else if ((pa & pb) == 1)
            {
                result += 2;
            }
            else
            {
                result += 1;
            }
        }

        return result;
    }
}
// @lc code=end

