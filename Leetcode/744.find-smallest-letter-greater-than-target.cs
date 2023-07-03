/*
 * @lc app=leetcode id=744 lang=csharp
 *
 * [744] Find Smallest Letter Greater Than Target
 */

// @lc code=start
public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        var result = char.MaxValue;

        foreach (var c in letters)
        {
            if (c > target && c < result)
            {
                result = c;
            }
        }

        return result == char.MaxValue ? letters[0] : result;
    }
}
// @lc code=end

