/*
 * @lc app=leetcode id=2976 lang=csharp
 *
 * [2976] Minimum Cost to Convert String I
 */

// @lc code=start
public class Solution {
    public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost) {
        long[,] maps = new long[26, 26];
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                maps[i, j] = -1L;
            }
            maps[i, i] = 0L;
        }

        int ori = 0,
            cha = 0;
        for (int i = 0; i < original.Length; i++)
        {
            ori = original[i] - 'a';
            cha = changed[i] - 'a';
            if (maps[ori, cha] < 0)
            {
                maps[ori, cha] = cost[i];
            }
            else
            {
                maps[ori, cha] = Math.Min(maps[ori, cha], cost[i]);
            }
        }

        for (int k = 0; k < 26; k++)
        {
            for (int i = 0; i < 26; i++)
            {
                if (maps[i, k] < 0)
                {
                    continue;
                }

                for (int j = 0; j < 26; j++)
                {
                    if (maps[k, j] < 0)
                    {
                        continue;
                    }


                    if (maps[i, j] < 0)
                    {
                        maps[i, j] = maps[i, k] + maps[k, j];
                    }
                    else
                    {
                        maps[i, j] = Math.Min(maps[i, j], maps[i, k] + maps[k, j]);
                    }
                }
            }
        }

        long result = 0,
            c = 0;
        for (int i = 0; i < source.Length; i++)
        {
            c = maps[source[i] - 'a', target[i] - 'a'];
            if (c == -1)
            {
                return -1;
            }
            result += c;
        }
        return result;
    }
}
// @lc code=end

