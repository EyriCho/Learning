/*
 * @lc app=leetcode id=1200 lang=csharp
 *
 * [1200] Minimum Absolute Difference
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        int min = arr[^1] - arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            min = Math.Min(min, arr[i] - arr[i - 1]);
        }

        List<IList<int>> result = new ();
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] == min)
            {
                result.Add(new List<int> {arr[i - 1], arr[i]});
            }
        }

        return result;
    }
}
// @lc code=end

