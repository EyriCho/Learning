/*
 * @lc app=leetcode id=1189 lang=csharp
 *
 * [1189] Maximum Number of Balloons
 */

// @lc code=start
public class Solution {
    public int MaxNumberOfBalloons(string text) {
        var charCounts = new int[26];
        
        foreach (var c in text)
            charCounts[c - 'a']++;
        
        var result = 10_000;
        
        result = Math.Min(result, charCounts[0]); // 'a'
        result = Math.Min(result, charCounts[1]); // 'b'
        result = Math.Min(result, charCounts[11] / 2); // 'l'
        result = Math.Min(result, charCounts[13]); // 'n'
        result = Math.Min(result, charCounts[14] / 2); // 'o'
        
        return result;
    }
}
// @lc code=end

