/*
 * @lc app=leetcode id=3607 lang=csharp
 *
 * [3607] Power Grid Maintenance
 */

// @lc code=start
public class Solution {
    public int[] ProcessQueries(int c, int[][] connections, int[][] queries) {
        int[] groups = new int[c + 1];
        for (int i = 1; i <= c; i++)
        {
            groups[i] = i;
        }

        int FindGroup(int station)
        {
            if (groups[station] == station)
            {
                return station;
            }

            return groups[station] = FindGroup(groups[station]);
        }

        int groupU = 0,
            groupV = 0;
        foreach (int[] connection in connections)
        {
            groupU = FindGroup(connection[0]);
            groupV = FindGroup(connection[1]);

            if (groupU < groupV)
            {
                groups[groupV] = groupU;
            }
            else if (groupU > groupV)
            {
                groups[groupU] = groupV;
            }
        }

        Dictionary<int, int> minDict = new ();
        int[] offlines = new int[c + 1];
        foreach (int[] query in queries)
        {
            if (query[0] == 2)
            {
                offlines[query[1]]++;
            }
        }

        int min = 0;
        for (int i = 1; i <= c; i++)
        {
            groupU = FindGroup(i);
            if (!minDict.TryGetValue(groupU, out min))
            {
                minDict[groupU] = -1;
            }

            min = minDict[groupU];
            if (offlines[i] == 0 &&
                (min == -1 || min > i))
            {
                minDict[groupU] = i;
            }
        }

        List<int> list = new ();
        for (int i = queries.Length - 1; i >= 0; i--)
        {
            groupU = FindGroup(queries[i][1]);
            minDict.TryGetValue(groupU, out min);
            
            if (queries[i][0] == 1)
            {
                if (offlines[queries[i][1]] > 0)
                {
                    list.Add(min);
                }
                else
                {
                    list.Add(queries[i][1]);
                }
            }
            else
            {
                offlines[queries[i][1]]--;
                if (offlines[queries[i][1]] == 0 &&
                    (min == -1 || min > queries[i][1]))
                {
                    minDict[groupU] = queries[i][1];
                }
            }
        }
        list.Reverse();
        return list.ToArray();
    }
}
// @lc code=end

