/*
 * @lc app=leetcode id=1964 lang=csharp
 *
 * [1964] Find the Longest Valid Obstacle Course at Each Position
 */

// @lc code=start
public class Solution {
    public int[] LongestObstacleCourseAtEachPosition(int[] obstacles) {
        var result = new int[obstacles.Length];
        result[0] = 1;

        var array = new int[obstacles.Length];
        array[0] = obstacles[0];
        int length = 1;

        int Search(int num)
        {
            int l = 0, r = length;
            while (l < r)
            {
                var m = (l + r) >> 1;
                if (array[m] <= num)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            return r;
        }

        for (int i = 1; i < obstacles.Length; i++)
        {
            result[i] = 1;
            var index = Search(obstacles[i]);
            if (index >= length)
            {
                array[length++] = obstacles[i];
                result[i] = length;
            }
            else
            {
                array[index] = obstacles[i];
                result[i] = index + 1;
            }
        }

        return result;
    }
}
// @lc code=end

