/*
 * @lc app=leetcode id=1701 lang=csharp
 *
 * [1701] Average Waiting Time
 */

// @lc code=start
public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        double waiting = 0D;
        int time = 0;

        foreach (int[] customer in customers)
        {
            time = Math.Max(time, customer[0]) + customer[1];
            waiting += time - customer[0];
        }

        return waiting / customers.Length;
    }
}
// @lc code=end

