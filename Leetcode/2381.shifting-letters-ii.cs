/*
 * @lc app=leetcode id=2381 lang=csharp
 *
 * [2381] Shifting Letters II
 */

// @lc code=start
public class Solution {
    public string ShiftingLetters(string s, int[][] shifts) {
        int[] delta = new int[s.Length];
        for (int i = 0; i < shifts.Length; i++)
        {
            delta[shifts[i][0]] += shifts[i][2] == 1 ? 1 : -1;
            if (shifts[i][1] + 1 != s.Length)
            {
                delta[shifts[i][1] + 1] += shifts[i][2] == 1 ? -1 : 1;
            }
        }

        int total = 0;

        char[] array = s.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            total += delta[i];

            array[i] = (char)(array[i] + total % 26);
            if (array[i] < 'a')
            {
                array[i] = (char)(array[i] + 26);
            }
            else if (array[i] > 'z')
            {
                array[i] = (char)(array[i] - 26);
            }
        }

        return new string(array);
    }
}
// @lc code=end

