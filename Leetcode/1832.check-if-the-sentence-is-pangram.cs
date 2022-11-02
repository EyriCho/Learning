/*
 * @lc app=leetcode id=1832 lang=csharp
 *
 * [1832] Check if the Sentence Is Pangram
 */

// @lc code=start
public class Solution {
    public bool CheckIfPangram(string sentence) {
        var letters = new bool[26];
        foreach (var c in sentence)
        {
            letters[c - 'a'] = true;
        }
        
        foreach (var l in letters)
        {
            if (!l)
            {
                return false;
            }
        }
        
        return true;
    }
}
// @lc code=end

