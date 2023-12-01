/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [2642] Design Graph With Shortest Path Calculator
 */

// @lc code=start
public class Solution {
    public Graph(int n, int[][] edges) {
        costs = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                costs[i, j] = -1;
            }
        }

        foreach (int[] edge in edges)
        {
            costs[edge[0], edge[1]] = edge[2];
        }
    }

    int[,] costs;
    
    public void AddEdge(int[] edge) {
        costs[edge[0], edge[1]] = edge[2];
    }
    
    public int ShortestPath(int node1, int node2) {
        int n = costs.GetLength(0);
        int[] distance = new int[n];
        bool[] visited = new bool[n];
        Array.Fill(distance, -1);
        distance[node1] = 0;

        while (true)
        {
            int minIndex = -1,
                min = -1;

            for (int i = 0; i < n; i++)
            {
                if (!visited[i] &&
                    distance[i] != -1 &&
                    (min == -1 || distance[i] < min))
                {
                    minIndex = i;
                    min = distance[i];
                }
            }

            if (minIndex == -1)
            {
                break;
            }

            visited[minIndex] = true;
            for (int i = 0; i < n; i++)
            {
                if (costs[minIndex, i] > 0 &&
                    (distance[i] == -1 || distance[i] > distance[minIndex] + costs[minIndex, i]))
                {
                    distance[i] = distance[minIndex] + costs[minIndex, i];
                }
            }
        }

        return distance[node2] == int.MaxValue ? -1 : distance[node2];
    }
}
// @lc code=end

