/*
 * @lc app=leetcode id=2615 lang=csharp
 *
 * [2615] Sum of Distances
 */

// @lc code=start
public class Solution {
    public long[] Distance(int[] nums) {
        Dictionary<int, IList<int>> dict = new ();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.TryGetValue(nums[i], out IList<int> list))
            {
                dict[nums[i]] = list = new List<int>();
            }
            list.Add(i);
        }

        long[] result = new long[nums.Length];
        long total = 0L,
            prefixTotal = 0L;
        foreach (IList<int> list in dict.Values)
        {
            if (list.Count == 1)
            {
                result[list[0]] = 0L;
                continue;
            }

            prefixTotal = total = 0L;
            foreach (int idx in list)
            {
                total += idx;
            }

            for (int j = 0; j < list.Count; j++)
            {
                result[list[j]] = total - prefixTotal * 2L + list[j] * (2L * j - list.Count);
                prefixTotal += list[j];
            }
        }

        return result;
    }
}
// @lc code=end

