/*
 * @lc app=leetcode id=1446 lang=csharp
 *
 * [1446] Consecutive Characters
 */

// @lc code=start
public class Solution {
    public int MaxPower(string s) {
        int result = 1, count = 1;
        
        char c = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            if (c == s[i])
            {
                count++;
            }
            else
            {
                if (count > result)
                    result = count;
                c = s[i];
                count = 1;
            }
        }
        
        return count > result ? count : result;
    }
}
// @lc code=end

