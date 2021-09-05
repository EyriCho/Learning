/*
 * @lc app=leetcode id=639 lang=csharp
 *
 * [639] Decode Ways II
 */

// @lc code=start
public class Solution {
    public int NumDecodings(string s) {
        if (s[0] == '0')
            return 0;
        long result = s[0] == '*' ? 9L : 1L;
        const int mod = 1_000_000_007;
        
        long prev = 1;
        char prevChar = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            long temp = prev;
            prev = result;
            if (s[i] == '*')
            {
                if (prevChar == '*')
                    result = (result * 9 + temp * 15) % mod;
                else if (prevChar == '0')
                    result = result * 9 % mod;
                else if (prevChar == '1')
                    result = (result * 9 + temp * 9) % mod;
                else if (prevChar == '2')
                    result = (result * 9 + temp * 6) % mod;
                else
                    result = result * 9 % mod;
            }
            else if (s[i] == '0')
            {
                if (prevChar == '0' || (prevChar >= '3' && prevChar <= '9'))
                    return 0;
                else if (prevChar == '*')
                    result = temp * 2 % mod;
                else
                    result = temp;
            }
            else if (s[i] >= '1' && s[i] <= '6')
            {
                if (prevChar == '*')
                    result = (result + temp * 2) % mod;
                else if (prevChar == '1' || prevChar == '2')
                    result = (result + temp) % mod;
            }
            else
            {
                if (prevChar == '*' || prevChar == '1')
                    result = (result + temp) % mod;
            }
            
            prevChar = s[i];
        }
        
        return (int)result;
    }
}
// @lc code=end

