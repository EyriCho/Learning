/*
 * @lc app=leetcode id=506 lang=csharp
 *
 * [506] Relative Ranks
 */

// @lc code=start
public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        (int, int)[] array = new (int, int)[score.Length];
        for (int i = 0; i < score.Length; i++)
        {
            array[i] = (score[i], i);
        }
        Array.Sort(array, (a, b) => b.Item1.CompareTo(a.Item1));

        string[] result = new string[score.Length];
        result[array[0].Item2] = "Gold Medal";
        if (score.Length > 1)
        {
            result[array[1].Item2] = "Silver Medal";
        }
        if (score.Length > 2)
        {
            result[array[2].Item2] = "Bronze Medal";
        }

        for (int i = 3; i < score.Length; i++)
        {
            result[array[i].Item2] = (i + 1).ToString();
        }

        return result;
    }
}
// @lc code=end

