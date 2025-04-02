/*
 * @lc app=leetcode id=3169 lang=csharp
 *
 * [3169] Count Days Without Meetings
 */

// @lc code=start
public class Solution {
    public int CountDays(int days, int[][] meetings) {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> list = new ();

        list.Add(meetings[0]);
        for (int i = 1; i < meetings.Length; i++)
        {
            if (meetings[i][0] <= list[^1][1])
            {
                list[^1][1] = Math.Max(list[^1][1], meetings[i][1]);
            }
            else
            {
                list.Add(meetings[i]);
            }
        }

        int result = 0;
        if (list[0][0] > 1)
        {
            result = list[0][0] - 1;
        }

        for (int i = 1; i < list.Count; i++)
        {
            result += list[i][0] - list[i - 1][1] - 1;
        }

        if (days > list[^1][1])
        {
            result += days - list[^1][1];
        }
        return result;
    }
}
// @lc code=end

