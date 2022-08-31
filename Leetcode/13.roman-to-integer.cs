/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        var dict = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        
        var result = 0;
        var subTotal = dict[s[0]];
        for (int i = 1; i < s.Length; i++)
        {
            var prev = dict[s[i - 1]];
            var curr = dict[s[i]];
            
            if (curr > prev)
            {
                result -= subTotal;
                subTotal = curr;
            }
            else if (curr < prev)
            {
                result += subTotal;
                subTotal = curr;
            }
            else
            {
                subTotal += curr;
            }
            
        }
        
        result += subTotal;
        
        return result;
    }
}
// @lc code=end

