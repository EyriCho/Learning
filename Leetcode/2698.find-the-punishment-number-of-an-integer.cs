/*
 * @lc app=leetcode id=2698 lang=csharp
 *
 * [2698] Find the Punishment Number of an Integer
 */

// @lc code=start
public class Solution {
    public int PunishmentNumber(int n) {
        if (n < 9)
        {
            return 1;
        }
        
        bool IsPunishment(int num, int target)
        {
            if (target < 0)
            {
                return false;
            }

            if (num == target)
            {
                return true;
            }

            int module = 1;
            while (module < num)
            {
                module *= 10;
                if (IsPunishment(num / module, target - num % module))
                {
                    return true;
                }
            }

            return false;
        }

        int result = 1;
        for (int i = 9; i <= n; i++)
        {
            if (IsPunishment(i * i, i))
            {
                result += i * i;
            }
        }

        return result;
    }
}
// @lc code=end

