/*
 * @lc app=leetcode id=856 lang=csharp
 *
 * [856] Score of Parentheses
 */

// @lc code=start
public class Solution {
    public int ScoreOfParentheses(string S) {
        int result = 0,
            count = 0;
        
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] == '(')
                count++;
            else
            {
                count--;
                if (S[i - 1] == '(')
                    result += 1 << count;
            }
        }
        
        return result;
    }
}
// @lc code=end

