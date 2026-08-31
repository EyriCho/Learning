/*
 * @lc app=leetcode id=3016 lang=csharp
 *
 * [3016] Minimum Number of Pushes to Type Word II
 */

// @lc code=start
public class Solution {
    public int MinimumPushes(string word) {
        int[] counts = new int[26];
        foreach (char c in word)
        {
            counts[c - 'a']++;
        }

        Array.Sort(counts);
        int result = 0,
            letters = 0,
            push = 1;
        for (int i = 25; i >= 0; i--)
        {
            if (counts[i] == 0)
            {
                break;
            }

            result += counts[i] * push;
            letters++;
            if (letters % 8 == 0)
            {
                push++;
            }
        }
        return result;
    }
}
// @lc code=end

