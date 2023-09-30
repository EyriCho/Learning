/*
 * @lc app=leetcode id=646 lang=csharp
 *
 * [646] Maximum Length of Pair Chain
 */

// @lc code=start
public class Solution {
    public int FindLongestChain(int[][] pairs) {
        Array.Sort(pairs, (a, b) => a[1] - b[1]);
        var max = 0;
        var last = int.MinValue;
        foreach (var pair in pairs)
        {
            if (pair[0] > last)
            {
                max++;
                last = pair[1];
            }
        }

        return max;
    }
}
// @lc code=end

