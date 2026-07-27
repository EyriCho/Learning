/*
 * @lc app=leetcode id=1189 lang=csharp
 *
 * [1189] Maximum Number of Balloons
 */

// @lc code=start
public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int[] charCounts = new int[26];
        
        foreach (var c in text)
        {
            charCounts[c - 'a']++;
        }
        
        int result = Math.Min(charCounts[0], charCounts[1]); // 'a' and 'b'
        
        result = Math.Min(result, charCounts[11] / 2); // 'l'
        result = Math.Min(result, charCounts[13]); // 'n'
        result = Math.Min(result, charCounts[14] / 2); // 'o'
        
        return result;
    }
}
// @lc code=end

