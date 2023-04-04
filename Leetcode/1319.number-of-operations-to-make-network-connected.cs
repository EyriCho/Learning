/*
 * @lc app=leetcode id=1319 lang=csharp
 *
 * [1319] Number of Operations to Make Network Connected
 */

// @lc code=start
public class Solution {
    public int MakeConnected(int n, int[][] connections) {
        if (connections.Length < n - 1)
        {
            return -1;
        }

        var groups = new int[n];
        for (int i = 0; i < n; i++)
        {
            groups[i] = i;
        }

        int GetRoot(int num)
        {
            while (groups[num] != num)
            {
                num = groups[num];
            }

            return num;
        }

        foreach (var connection in connections)
        {
            int rootA = GetRoot(connection[0]),
                rootB = GetRoot(connection[1]);
            
            int root = Math.Min(rootA, rootB);
            groups[rootA] = groups[rootB] = root;
        }

        var result = 0;
        for (int i = 0; i < n; i++)
        {
            if (groups[i] == i)
            {
                result++;
            }
        }
        return result - 1;
    }
}
// @lc code=end

