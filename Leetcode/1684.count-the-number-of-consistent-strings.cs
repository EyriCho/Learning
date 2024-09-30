/*
 * @lc app=leetcode id=1684 lang=csharp
 *
 * [1684] Count the Number of Consistent Strings
 */

// @lc code=start
public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        bool[] characters = new bool[26];
        foreach (char c in allowed)
        {
            characters[c - 'a'] = true;
        }

        int result = 0,
            isConsist = 0;
        foreach (string word in words)
        {
            isConsist = 1;
            foreach (char c in word)
            {
                if (!characters[c - 'a'])
                {
                    isConsist = 0;
                    break;
                }
            }

            result += isConsist;
        }

        return result;
    }
}
// @lc code=end

