/*
 * @lc app=leetcode id=2092 lang=csharp
 *
 * [2092] Find All People With Secret
 */

// @lc code=start
public class Solution {
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson) {
        int[] group = new int[n];
        for (int p = 1; p < n; p++)
        {
            group[p] = p;
        }
        group[firstPerson] = 0;

        int FindGroup(int p) => group[p] = (p == group[p] ? p : FindGroup(group[p]));

        Dictionary<int, IList<(int, int)>> timeDict = new ();
        foreach (int[] meeting in meetings)
        {
            if (!timeDict.TryGetValue(meeting[2], out IList<(int, int)> list))
            {
                timeDict[meeting[2]] = list = new List<(int, int)>();
            }

            list.Add((meeting[0], meeting[1]));
        }

        int aGroup = 0, bGroup = 0;

        for (int t = 1; t <= 100_000; t++)
        {
            if (!timeDict.ContainsKey(t))
            {
                continue;
            }

            foreach ((int a, int b) in timeDict[t])
            {
                aGroup = FindGroup(a);
                bGroup = FindGroup(b);

                if (aGroup == 0 || bGroup == 0)
                {
                    group[aGroup] = 0;
                    group[bGroup] = 0;
                }

                group[FindGroup(a)] = group[FindGroup(b)];
            }

            foreach ((int a, int b) in timeDict[t])
            {
                aGroup = FindGroup(a);
                bGroup = FindGroup(b);
                if (aGroup == 0 || bGroup == 0)
                {
                    group[aGroup] = 0;
                    group[bGroup] = 0;
                }
                else
                {
                    group[a] = a;
                    group[b] = b;
                }
            }
        }

        List<int> result = new ();
        for (int i = 0; i < n; i++)
        {
            if (FindGroup(i) == 0)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
// @lc code=end

