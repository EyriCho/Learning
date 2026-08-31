/*
 * @lc app=leetcode id=3517 lang=csharp
 *
 * [3517] Smallest Palindromic Rearrangement I
 */

// @lc code=start
public class Solution {
    public string SmallestPalindrome(string s) {
        int half = s.Length >> 1;
        char[] array = new char[s.Length];
        int[] counts = new int[26];

        if ((s.Length & 1) == 1)
        {
            array[half] = s[half];
        }
        for (int i = 0; i < half; i++)
        {
            counts[s[i] - 'a']++;
        }
        int l = 0, r = s.Length - 1;
        for (int i = 0; i < 26; i++)
        {
            while (counts[i] > 0)
            {
                array[l++] = array[r--] = (char)('a' + i);
                counts[i]--;
            }
        }

        return new string(array);
    }
}
// @lc code=end

