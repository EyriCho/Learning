/*
 * @lc app=leetcode id=520 lang=csharp
 *
 * [520] Detect Capital
 */

// @lc code=start
public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word.Length == 1) return true;

        bool first = word[0] < 'a';
        bool last = word[1] < 'a';
        if (!first && last) return false;
        
        for (int i = 2; i < word.Length; i++)
        {
            var current = word[i] < 'a';
            if (last != current)
                return false;
            last = current;
        }
        
        return true;
    }
}
// @lc code=end

