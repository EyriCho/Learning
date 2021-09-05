/*
 * @lc app=leetcode id=91 lang=csharp
 *
 * [91] Decode Ways
 */

// @lc code=start
public class Solution {
    public int NumDecodings(string s) {
        if (s[0] == '0')
            return 0;
        
        int result = 1, prev = 1;
        var prevChar = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            int temp = prev;
            prev = result;
            if (s[i] == '0' )
            {
                if (prevChar == '1' || prevChar == '2')
                    result = temp;
                else
                    return 0;
            }
            else if (s[i] >= '1' && s[i] <= '6')
            {
                if (prevChar == '1' || prevChar == '2')
                    result = result + temp;
            }
            else
            {
                if (prevChar == '1')
                    result = result + temp;
            }
            prevChar = s[i];
        }
        
        return result;
    }
}
// @lc code=end

