/*
 * @lc app=leetcode id=2092 lang=csharp
 *
 * [2092] Find All People With Secret
 */

// @lc code=start
public class Solution {
    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson) {
        Dictionary<int, IList<(int, int)>> timeDict = new();
        foreach (int[] meeting in meetings)
        {
            if (!timeDict.TryGetValue(meeting[2], out IList<(int, int)> list))
            {
                timeDict[meeting[2]] = list = new List<(int, int)>();
            }

            list.Add((meeting[0], meeting[1]));
        }

        int[] group = new int[n];
        for (int i = 0; i < n; i++)
        {
            group[i] = i;
        }
        group[firstPerson] = 0;

        int Find(int person)
        {
            if (group[person] != person)
            {
                return group[person] = Find(group[person]);
            }

            return person;
        }

        for (int time = 1; time < 100_001; time++)
        {
            if (!timeDict.ContainsKey(time))
            {
                continue;
            }

            foreach ((int a, int b) in timeDict[time])
            {
                int aGroup = Find(a),
                    bGroup = Find(b);
                if (aGroup == 0 || bGroup == 0)
                {
                    group[aGroup] = 0;
                    group[bGroup] = 0;
                }
                group[Find(a)] = group[Find(b)];
            }

            foreach ((int a, int b) in timeDict[time])
            {
                int aGroup = Find(a),
                    bGroup = Find(b);
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

        List<int> result = new();
        for (int i = 0; i < n; i++)
        {
            if (Find(i) == 0)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
// @lc code=end

