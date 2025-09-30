/*
 * @lc app=leetcode id=3227 lang=csharp
 *
 * [3227] Vowels Game in a String 
 */

// @lc code=start
public class Solution {
    public bool DoesAliceWin(string s) {
        HashSet<char> set = new () {
            'a', 'e', 'i', 'o', 'u',
        };
        int i = 0;
        while (i < s.Length)
        {
            if (set.Contains(s[i]))
            {
                return true;
            }
            i++;
        }
        
        return false;;
    }
}
// @lc code=end

