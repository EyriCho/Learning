/*
 * @lc app=leetcode id=2477 lang=csharp
 *
 * [2477] Minimum Fuel Cost to Report to the Capital
 */

// @lc code=start
public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        var map = new IList<int>[roads.Length + 1];
        for (int i = 0; i <= roads.Length; i++)
        {
            map[i] = new List<int>();
        }
        foreach (var road in roads)
        {
            map[road[0]].Add(road[1]);
            map[road[1]].Add(road[0]);
        }

        var visited = new bool[roads.Length + 1];
        visited[0] = true;
        long result = 0;
        (int, int) dfs(int index)
        {
            int count = 1;
            foreach (var next in map[index])
            {
                if (!visited[next])
                {
                    visited[next] = true;
                    count += dfs(next).Item1;
                }
            }
            var cars = count / seats + (count % seats == 0 ? 0 : 1);
            result += cars;
            return (count, cars);
        }

        var (_, car) = dfs(0);

        return result - car;
    }
}
// @lc code=end

