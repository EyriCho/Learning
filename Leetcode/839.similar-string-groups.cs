/*
 * @lc app=leetcode id=839 lang=csharp
 *
 * [839] Similar String Groups
 */

// @lc code=start
public class Solution {
    public int NumSimilarGroups(string[] strs) {
        var group = new int[strs.Length];
        for (int i = 0; i < strs.Length; i++)
        {
            group[i] = i;
        }

        bool IsSimilar(string a, string b)
        {
            var mismatch = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    mismatch++;
                }
            }

            return mismatch <= 2;
        }

        int Find(int index)
        {
            if (group[index] != index)
            {
                return group[index] = Find(group[index]);
            }

            return index;
        }

        for (int i = 0; i < strs.Length; i++)
        {
            for (int j = i + 1; j < strs.Length; j++)
            {
                int gi = Find(i),
                    gj = Find(j);

                if (gi == gj)
                {
                    continue;
                }
                if (IsSimilar(strs[i], strs[j]))
                {
                    group[gi] = gj;
                }
            }
        }

        int result = 0;
        for (int i = 0; i < strs.Length; i++)
        {
            if (group[i] == i)
            {
                result++;
            }
        }

        return result
    }
}
// @lc code=end

