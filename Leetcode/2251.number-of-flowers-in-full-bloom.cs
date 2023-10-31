/*
 * @lc app=leetcode id=2251 lang=csharp
 *
 * [2251] Number of Flowers in Full Bloom
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var time = new (int, int)[flowers.Length * 2 + people.Length];
        int t = 0;
        foreach (var f in flowers)
        {
            time[t++] = (f[0], -1);
            time[t++] = (f[1] + 1, -2);
        }
        for (int i = 0; i < people.Length; i++)
        {
            time[t++] = (people[i], i);
        }

        Array.Sort(time);

        var count = 0;
        for (t = 0; t < time.Length; t++)
        {
            if (time[t].Item2 == -1)
            {
                count++;
            }
            else if (time[t].Item2 == -2)
            {
                count--;
            }
            else
            {
                people[time[t].Item2] = count;
            }
        }

        return people;
    }
}
// @lc code=end

