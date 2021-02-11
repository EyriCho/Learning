/*
 * @lc app=leetcode id=1657 lang=csharp
 *
 * [1657] Determine if Two Strings Are Close
 */

// @lc code=start
public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if (word1.Length != word2.Length)
            return false;
        
        int[] char1 = new int[26],
            char2 = new int[26];
        
        for (int i = 0; i < word1.Length; i++)
        {
            char1[word1[i] - 'a']++;
            char2[word2[i] - 'a']++;
        }
        
        for (int i = 0; i < 26; i++)
        {
            if (char1[i] > 0 && char2[i] == 0)
                return false;
            
            if (char1[i] == 0 && char2[i] > 0)
                return false;
        }

        Array.Sort(char1);
        Array.Sort(char2);
        
        for (int i = 0; i < 26; i++)
        {
            if (char1[i] != char2[i])
                return false;
        }
        return true;
    }
}
// @lc code=end

