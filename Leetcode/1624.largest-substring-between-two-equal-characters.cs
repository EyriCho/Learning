/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1624] Largest Substring Between Two Equal Characters
 */

// @lc code=start
public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int[] prevs = new int[26];
        Array.Fill(prevs, -1);
        int pos = 0,
            result = -1;

        for (int i = 0; i < s.Length; i++)
        {
            pos = s[i] - 'a';
            if (prevs[pos] > -1)
            {
                result = Math.Max(result, i - prevs[pos] - 1);
            }
            else
            {
                prevs[pos] = i;
            }
        }
        
        return result;
    }
}
// @lc code=end

