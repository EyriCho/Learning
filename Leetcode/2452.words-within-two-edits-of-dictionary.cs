/*
 * @lc app=leetcode id=2452 lang=csharp
 *
 * [2452] Words Within Two Edits of Dictionary
 */

// @lc code=start
public class Solution {
    public IList<string> TwoEditWords(string[] queries, string[] dictionary) {
        List<string> result = new ();

        int diff = 0;
        for (int i = 0; i < queries.Length; i++)
        {
            for (int d = 0; d < dictionary.Length; d++)
            {
                diff = 0;
                for (int c = 0; c < queries[i].Length; c++)
                {
                    if (queries[i][c] == dictionary[d][c])
                    {
                        continue;
                    }
                    diff++;
                }

                if (diff <= 2)
                {
                    result.Add(queries[i]);
                    break;
                }
            }
        }

        return result;
    }
}
// @lc code=end

