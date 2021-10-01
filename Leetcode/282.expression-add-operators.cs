/*
 * @lc app=leetcode id=282 lang=csharp
 *
 * [282] Expression Add Operators
 */

// @lc code=start
public class Solution {
    public IList<string> AddOperators(string num, int target) {
        var result = new List<string>();
        
        void Recursion(string left, string s, long temp, long diff)
        {
            if (left.Length == 0)
            {
                if (temp == target)
                    result.Add(s);
                return;
            }
            
            for (int i = 1; i <= left.Length; i++)
            {
                var numStr = left[0..i];

                if (left[0] == '0' && numStr.Length > 1)
                    return;
                var newTemp = long.Parse(numStr);
                var newLeft = left[i..];
                if (s.Length > 0)
                {
                    Recursion(newLeft, s + '+' + numStr, temp + newTemp, newTemp);
                    Recursion(newLeft, s + '-' + numStr, temp - newTemp, -newTemp);
                    Recursion(newLeft, s + '*' + numStr, temp - diff + diff * newTemp, diff * newTemp);
                }
                else
                    Recursion(newLeft, numStr, newTemp, newTemp);
            }
        }
        
        Recursion(num, string.Empty, 0, 0);
        
        return result;
    }
}
// @lc code=end

