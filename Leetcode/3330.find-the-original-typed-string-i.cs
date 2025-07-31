/*
 * @lc app=leetcode id=3330 lang=csharp
 *
 * [3330] Find the Original Typed String I
 */

// @lc code=start
public class Solution {
    public int PossibleStringCount(string word) {
        int i = 0,
            l = 0,
            result = 1;
        while (i < word.Length)
        {
            l = i;
            while (i < word.Length && word[l] == word[i])
            {
                i++;
            }

            result += i - l - 1;
        }
        return result;
    }
}
// @lc code=end

