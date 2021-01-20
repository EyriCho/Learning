/*
 * @lc app=leetcode id=1641 lang=csharp
 *
 * [1641] Count Sorted Vowel Strings
 */

// @lc code=start
public class Solution {
    public int CountVowelStrings(int n) {
        int[] counts = { 1, 1, 1, 1, 1 };
        
        for (int i = 1; i < n; i++)
        {
            counts[3] += counts[4];
            counts[2] += counts[3];
            counts[1] += counts[2];
            counts[0] += counts[1];
        }
        
        return counts[4] + counts[3] + counts[2] +
            counts[1] + counts[0];
    }
}
// @lc code=end

