/*
 * @lc app=leetcode id=3443 lang=csharp
 *
 * [3443] Maximum Manhattan Distance After K Changes
 */

// @lc code=start
public class Solution {
    public int MaxDistance(string s, int k) {
        int hori = 0, verti = 0,
            result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'E':
                    hori++;
                    break;
                case 'N':
                    verti++;
                    break;
                case 'W':
                    hori--;
                    break;
                case 'S':
                    verti--;
                    break;
            }

            result = Math.Max(result,
                Math.Min(Math.Abs(hori) + Math.Abs(verti) + 2 * k, i + 1));
        }

        return result;
    }
}
// @lc code=end

