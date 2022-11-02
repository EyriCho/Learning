/*
 * @lc app=leetcode id=1662 lang=csharp
 *
 * [1662] Check If Two String Arrays are Equivalent
 */

// @lc code=start
public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        int w1 = 0, w2 = 0,
            i1 = 0, i2 = 0;
        
        while (w1 < word1.Length && w2 < word2.Length)
        {
            if (word1[w1][i1] != word2[w2][i2])
            {
                return false;
            }
            
            i1++;
            if (i1 == word1[w1].Length)
            {
                w1++;
                i1 = 0;
            }
            
            i2++;
            if (i2 == word2[w2].Length)
            {
                w2++;
                i2 = 0;
            }
        }
        
        return w1 == word1.Length && w2 == word2.Length;
    }
}
// @lc code=end

