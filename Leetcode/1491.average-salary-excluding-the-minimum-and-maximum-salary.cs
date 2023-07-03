/*
 * @lc app=leetcode id=1491 lang=csharp
 *
 * [1491] Average Salary Excluding the Minimum and Maximum Salary
 */

// @lc code=start
public class Solution {
    public double Average(int[] salary) {
        var total = 0D;
        int min = salary[0],
            max = salary[1];
        foreach (var s in salary)
        {
            total += s;
            min = Math.Min(min, s);
            max = Math.Max(max, s);
        }

        return (total - min - max) / (salary.Length - 2);
    }
}
// @lc code=end

