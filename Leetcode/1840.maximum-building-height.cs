/*
 * @lc app=leetcode id=1840 lang=csharp
 *
 * [1840] Maximum Building Height
 */

// @lc code=start
public class Solution {
    public int MaxBuilding(int n, int[][] restrictions) {
        List<int[]> list = new ();
        list.Add(new int[] { 1, 0 });
        list.AddRange(restrictions);
        list.Sort((a, b) => a[0].CompareTo(b[0]));
        if (list[^1][0] != n)
        {
            list.Add(new int[] { n, n - 1 });
        }

        for (int i = 1; i < list.Count; i++)
        {
            list[i][1] = Math.Min(list[i][1],
                list[i - 1][1] + list[i][0] - list[i - 1][0]);
        }

        for (int i = list.Count - 2; i >= 0; i--)
        {
            list[i][1] = Math.Min(list[i][1],
                list[i + 1][1] + list[i + 1][0] - list[i][0]);
        }

        int result = 0,
            best = 0;
        for (int i = 1; i < list.Count; i++)
        {
            best = (list[i - 1][1] + list[i][1] + list[i][0] - list[i - 1][0]) >> 1;

            result = Math.Max(result, best);
        }

        return result;
    }
}
// @lc code=end