/*
 * @lc app=leetcode id=2429 lang=csharp
 *
 * [2429] Minimize XOR
 */

// @lc code=start
public class Solution {
    public int MinimizeXor(int num1, int num2) {
        int count = 0,
            mask = 1,
            num = num2,
            x = 0;
        
        while (num > 0)
        {
            num &= num - 1;
            count++;
        }
        
        for (int i = 30; i >= 0 && count > 0; i--)
        {
            mask = 1 << i;

            if ((mask & num1) > 0)
            {
                x |= mask;
                count--;
            }
        }

        mask = 1;
        while (count > 0)
        {
            if ((mask & x) == 0)
            {
                x |= mask;
                count--;
            }
            mask <<= 1;
        }

        return x;
    }
}
// @lc code=end

