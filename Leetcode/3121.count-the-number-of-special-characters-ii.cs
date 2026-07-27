/*
 * @lc app=leetcode id=3121 lang=csharp
 *
 * [3121] Count the Number of Special Characters II
 */

// @lc code=start
public class Solution {
    public int NumberOfSpecialChars(string word) {
        int[] states = new int[26];
        int result = 0,
            idx = 0;

        foreach (char c in word)
        {
            if (c < 'a')
            {
                idx = c - 'A';
                if (states[idx] == 0)
                {
                    states[idx] = 3;
                }
                else if (states[idx] == 1)
                {
                    states[idx] = 2;
                }
            }
            else
            {
                idx = c - 'a';
                if (states[idx] == 0)
                {
                    states[idx] = 1;
                }
                else if (states[idx] == 2)
                {
                    states[idx] = 3;
                }
            }
        }

        foreach (int state in states)
        {
            if (state == 2)
            {
                result++;
            }
        }
        return result;
    }
}
// @lc code=end

