/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] target = new int[26],
            maga = new int[26];
        
        foreach (var c in ransomNote)
        {
            target[c - 'a']++;
        }
        
        foreach (var c in magazine)
        {
            maga[c - 'a']++;
        }
        
        for (int i = 0; i < 26; i++)
        {
            if (target[i] > maga[i])
            {
                return false;
            }
        }
        
        return true;
    }
}
// @lc code=end

