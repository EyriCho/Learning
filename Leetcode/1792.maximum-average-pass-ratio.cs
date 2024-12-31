/*
 * @lc app=leetcode id=1792 lang=csharp
 *
 * [1792] Maximum Average Pass Ratio
 */

// @lc code=start
public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents) {
        PriorityQueue<(double, int, int), double>
            queue = new (Comparer<double>.Create((a, b) => b.CompareTo(a)));

        double result = 0D,
            g = 0D;

        double GainByAddStudent(int p, int t)
        {
            return (double)(p + 1) / (t + 1) - (double)p / t;
        }

        foreach (int[] c in classes)
        {
            result += (double)c[0] / c[1];
            g = GainByAddStudent(c[0], c[1]);
            queue.Enqueue((g, c[0], c[1]), g);
        }

        (double gain, int pass, int total) max;
        while (extraStudents-- > 0)
        {
            max = queue.Dequeue();
            result += max.gain;
            g = GainByAddStudent(max.pass + 1, max.total + 1);
            queue.Enqueue((g, max.pass + 1, max.total + 1), g);
        }

        return result / classes.Length;
    }
}
// @lc code=end

