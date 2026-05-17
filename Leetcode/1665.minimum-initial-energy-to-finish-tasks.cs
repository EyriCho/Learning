/*
 * @lc app=leetcode id=1665 lang=csharp
 *
 * [1665] Minimum Initial Energy to Finish Tasks
 */

// @lc code=start
public class Solution {
    public int MinimumEffort(int[][] tasks) {
        Array.Sort(tasks, (a, b) => (a[1] - a[0]).CompareTo(b[1] - b[0]));

        int result = 0;
        foreach (int[] task in tasks)
        {
            result = Math.Max(result + task[0], task[1]);
        }

        return result;
    }
}
// @lc code=end

