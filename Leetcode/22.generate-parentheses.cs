/*
 * @lc app=leetcode id=22 lang=csharp
 *
 * [22] Generate Parentheses
 */

// @lc code=start
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        
        var temp = new char[n * 2];
        void Helper(int i, int l, int r)
        {
            if (l == n)
            {
                while (r++ < n)
                    temp[i++] = ')';
                result.Add(new string(temp));
            }
            else
            {
                temp[i] = '(';
                Helper(i + 1, l + 1, r);
                if (l > r)
                {
                    temp[i] = ')';
                    Helper(i + 1, l, r + 1);
                }
            }
        }
        
        Helper(0, 0, 0);
        
        return result;
    }
}
// @lc code=end

