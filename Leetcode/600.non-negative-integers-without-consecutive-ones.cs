/*
 * @lc app=leetcode id=600 lang=csharp
 *
 * [600] Non-negative Integers without Consecutive Ones
 */

// @lc code=start
public class Solution {
    public int FindIntegers(int n) {
        var f = new int[32];
        f[0] = 1;
        f[1] = 2;
        for (int i = 2; i <= 31; i++)
            f[i] = f[i - 1] + f[i - 2];
        
        int result = 0, k = 31;
        bool preIsOne = false;
        
        while (k >= 0)
        {
            if ((n & (1 << k)) > 0)
            {
                result += f[k];
                if (preIsOne)
                    return result;
                preIsOne = true;
            }
            else
                preIsOne = false;
            k--;
        }
        return result + 1;
    }
}
// @lc code=end

