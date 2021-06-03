/*
 * @lc app=leetcode id=318 lang=csharp
 *
 * [318] Maximum Product of Word Lengths
 */

// @lc code=start
public class Solution {
    public int MaxProduct(string[] words) {
        var result = 0;
        var digits = new int[words.Length];
        
        for (int i = 0; i < words.Length; i++)
        {
            var digit = 0;
            foreach (var c in words[i])
            {
                digit |= 1 << (c - 'a');
            }
            digits[i] = digit;
            
            for (int j = 0; j < i; j++)
            {
                if ((digits[j] & digit) == 0)
                    result = Math.Max(words[j].Length * words[i].Length, result);
            }
        }
        
        return result;
    }
}
// @lc code=end

