/*
 * @lc app=leetcode id=12 lang=csharp
 *
 * [12] Integer to Roman
 */

// @lc code=start
public class Solution {
    public string IntToRoman(int num) {
        int[] val = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] str = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        
        var result = new StringBuilder();
        var i = 0;
        while (num > 0)
        {
            if (num >= val[i])
            {
                result.Append(str[i]);
                num -= val[i];
            }
            else
                i++;
        }
        
        return result.ToString();
    }
}
// @lc code=end

