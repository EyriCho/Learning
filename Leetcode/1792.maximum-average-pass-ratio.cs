/*
 * @lc app=leetcode id=1792 lang=csharp
 *
 * [1792] Maximum Average Pass Ratio
 */

// @lc code=start
public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents) {
        double GainByExtra(int pass, int total)
        {
            return (double)(pass + 1) / (total + 1) - (double)pass / total;
        }

        PriorityQueue<(double, int, int), double> queue = new (Comparer<double>.Create((a, b) => b.CompareTo(a)));
        double result = 0D,
            gain = 0D,
            extra = 0D;
        foreach (int[] c in classes)
        {
            result += (double)c[0] / c[1];
            gain = GainByExtra(c[0], c[1]);
            queue.Enqueue((gain, c[0], c[1]), gain);
        }

        int pass = 0,
            total = 0;
        while (extraStudents--  > 0)
        {
            (gain, pass, total) = queue.Dequeue();
            result += gain;
            extra = GainByExtra(pass + 1, total + 1);
            queue.Enqueue((extra, pass + 1, total + 1), extra);
        }

        return result / classes.Length;
    }
}
// @lc code=end

