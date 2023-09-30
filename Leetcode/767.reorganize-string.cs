/*
 * @lc app=leetcode id=767 lang=csharp
 *
 * [767] Reorganize String
 */

// @lc code=start
public class Solution {
    public string ReorganizeString(string s) {
        var count = new int[26];
        foreach (var c in s)
        {
            count[c - 'a']++;
        }

        int max = (s.Length + 1) / 2,
            half = s.Length / 2;
        var array = new char[s.Length];
        int oddIndex = 1, evenIndex = 0;
        for (int i = 0; i < 26; i++)
        {
            if (count[i] > max)
            {
                return string.Empty;
            }

            var c = (char)(i + 'a');
            while (count[i] > 0 && count[i] <= half && oddIndex < s.Length)
            {
                array[oddIndex] = c;
                count[i]--;
                oddIndex += 2;
            }
            while (count[i] > 0)
            {
                array[evenIndex] = c;
                count[i]--;
                evenIndex += 2;
            }
        }

        return new string(array);
    }
}
// @lc code=end

