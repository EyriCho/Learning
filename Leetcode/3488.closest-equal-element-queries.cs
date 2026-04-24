/*
 * @lc app=leetcode id=3488 lang=csharp
 *
 * [3488] Closest Equal Element Queries
 */

// @lc code=start
public class Solution {
    public IList<int> SolveQueries(int[] nums, int[] queries) {
        Dictionary<int, (int, int)> dict = new ();
        int[] minDistance = new int[nums.Length];
        int minFirst = 0, minLast = 0,
            first = 0, last = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.TryGetValue(nums[i], out (int, int) prev))
            {
                first = prev.Item1;
                last = prev.Item2;
                minFirst = Math.Min(i - first, nums.Length - i + first);
                minDistance[first] = Math.Min(minDistance[first], minFirst);
                minLast = Math.Min(i - last, nums.Length - i + last);
                minDistance[last] = Math.Min(minDistance[last], minLast);
                minDistance[i] = Math.Min(minFirst, minLast);
                dict[nums[i]] = (first, i);
            }
            else
            {
                dict[nums[i]] = (i, i);
                minDistance[i] = nums.Length;
            }
        }
        
        List<int> result = new (queries.Length);
        foreach (int query in queries)
        {
            result.Add(minDistance[query] == nums.Length ? -1 : minDistance[query]);
        }

        return result;
    }
}
// @lc code=end

