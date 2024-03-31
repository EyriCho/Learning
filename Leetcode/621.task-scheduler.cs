/*
 * @lc app=leetcode id=621 lang=csharp
 *
 * [621] Task Scheduler
 */

// @lc code=start
public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        if (n == 0)
        {
            return tasks.Length;
        }

        int[] counts = new int[26];
        int max = 0,
            maxCount = 0,
            c = 0;
        foreach (char task in tasks)
        {
            c = task - 'A';
            counts[c]++;
            if (counts[c] > max)
            {
                max = counts[c];
                maxCount = 1;
            }
            else if (counts[c] == max)
            {
                maxCount++;
            }
        }

        int empty = (max - 1) * (n - (maxCount - 1)),
            idles = Math.Max(0, empty - (tasks.Length - maxCount * max));

        return idles + tasks.Length;
    }
}
// @lc code=end

