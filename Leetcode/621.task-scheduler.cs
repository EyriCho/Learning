/*
 * @lc app=leetcode id=621 lang=csharp
 *
 * [621] Task Scheduler
 */

// @lc code=start
public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        if (n == 0) return tasks.Length;
        int max = 0, maxCount = 0;
        var taskCount = new int[26];
        
        for (int i = 0; i < tasks.Length; i++)
        {
            var index = tasks[i] - 'A';
            taskCount[index]++;
            
            if (taskCount[index] > max)
            {
                max = taskCount[index];
                maxCount = 1;
            }
            else if (taskCount[index] == max)
                maxCount++;
        }
        
        var result = (max - 1) * (n + 1) + maxCount;
        return result > tasks.Length ? result : tasks.Length;
    }
}
// @lc code=end

