/*
 * @lc app=leetcode id=1903 lang=csharp
 *
 * [1903] Largest Odd Number in String
 */

// @lc code=start
public class Solution {
    public string LargestOddNumber(string num) {
        HashSet<char> set = new () {
            '1', '3', '5', '7', '9'
        };

        for (int i = num.Length - 1; i > -1; i--)
        {
            if (set.Contains(num[i]))
            {
                return num[0..(i + 1)];
            }
        }

        return string.Empty;
    }
}
// @lc code=end

