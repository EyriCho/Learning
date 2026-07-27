/*
 * @lc app=leetcode id=2492 lang=csharp
 *
 * [2492] Minimum Score of a Path Between Two Cities
 */

// @lc code=start
public class Solution {
    public int MinScore(int n, int[][] roads) {
        int[] groups = new int[n + 1];
        Dictionary<int, int> dict = new ();
        for (int i = 1; i <= n; i++)
        {
            groups[i] = i;
        }

        int FindGroup(int city)
        {
            return groups[city] = (city == groups[city] ? city : FindGroup(groups[city]));
        }

        int groupA = 0, groupB = 0, group = 0,
            distA = 0, distB = 0, dist = 0;
        foreach (int[] road in roads)
        {
            groupA = FindGroup(road[0]);
            groupB = FindGroup(road[1]);
            distA = dict.ContainsKey(groupA) ? dict[groupA] : 10_000;
            distB = dict.ContainsKey(groupB) ? dict[groupB] : 10_000;

            if (groupA < groupB)
            {
                group = groups[groupB] = groupA;
            }
            else if (groupA > groupB)
            {
                group = groups[groupA] = groupB;
            }
            else
            {
                group = groupA;
            }

            dist = Math.Min(distA, distB);
            dist = Math.Min(dist, road[2]);

            dict[group] = dist;
        }

        group = FindGroup(1);
        return dict[group];
    }
}
// @lc code=end

