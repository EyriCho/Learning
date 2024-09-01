/*
 * @lc app=leetcode id=860 lang=csharp
 *
 * [860] Lemonade Change
 */

// @lc code=start
public class Solution {
    public bool LemonadeChange(int[] bills) {
        int five = 0,
            ten = 0;

        foreach (int b in bills)
        {
            if (b == 5)
            {
                five++;
            }
            else if (b == 10)
            {
                if (five < 1)
                {
                    return false;
                }
                
                five--;
                ten++;
            }
            else 
            {
                if (ten > 0 && five > 0)
                {
                    ten--;
                    five--;
                }
                else if (five > 2)
                {
                    five -= 3;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}
// @lc code=end

