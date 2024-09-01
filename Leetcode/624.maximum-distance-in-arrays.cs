/*
 * @lc app=leetcode id=624 lang=csharp
 *
 * [624] Maximum Distance in Arrays
 */

// @lc code=start
public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        int min = arrays[0][0],
            max = arrays[0][arrays[0].Count - 1],
            tempMin = 0,
            tempMax = 0,
            result = int.MinValue;

        for (int i = 1; i < arrays.Count; i++)
        {
            tempMin = arrays[i][0];
            tempMax = arrays[i][arrays[i].Count - 1];

            result = Math.Max(result, Math.Max(tempMax - min, max - tempMin));

            min = Math.Min(min, tempMin);
            max = Math.Max(max, tempMax);
        }

        return result;
    }
}
// @lc code=end

