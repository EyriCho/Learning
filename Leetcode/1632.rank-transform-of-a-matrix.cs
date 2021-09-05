/*
 * @lc app=leetcode id=1632 lang=csharp
 *
 * [1632] Rank Transform of a Matrix
 */

// @lc code=start
public class Solution {
    public int[][] MatrixRankTransform(int[][] matrix) {
        var result = new int[matrix.Length][];
        var graphs = new Dictionary<int, Dictionary<int, IList<int>>>();
        
        for (int i = 0; i < matrix.Length; i++)
        {
            result[i] = new int[matrix[0].Length];
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (!graphs.ContainsKey(matrix[i][j]))
                    graphs.Add(matrix[i][j], new Dictionary<int, IList<int>>());
                
                var graph = graphs[matrix[i][j]];
                if (!graph.ContainsKey(i))
                    graph.Add(i, new List<int>());
                if (!graph.ContainsKey(~j))
                    graph.Add(~j, new List<int>());
                graph[i].Add(~j);
                graph[~j].Add(i);
            }
        }
        
        var sortedDict = new SortedDictionary<int, IList<IList<(int, int)>>>();
        var visited = new bool[matrix.Length, matrix[0].Length];

        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (visited[i, j])
                    continue;
                visited[i, j] = true;
                
                int val = matrix[i][j];
                var graph = graphs[val];
                var set = new HashSet<int>();
                set.Add(i);
                set.Add(~j);
                var queue = new Queue<int>();
                queue.Enqueue(i);
                queue.Enqueue(~j);
                while (queue.Count > 0)
                {
                    var index = queue.Dequeue();
                    foreach (var rowCol in graph[index])
                        if (!set.Contains(rowCol))
                        {
                            set.Add(rowCol);
                            queue.Enqueue(rowCol);
                        }
                }
                
                var points = new List<(int, int)>();
                foreach (var rowCol in set)
                    foreach (var k in graph[rowCol])
                        if (k >= 0)
                        {
                            points.Add((k, ~rowCol));
                            visited[k, ~rowCol] = true;
                        }
                        else
                        {
                            points.Add((rowCol, ~k));
                            visited[rowCol, ~k] = true;
                        }
                
                if (!sortedDict.ContainsKey(val))
                    sortedDict.Add(val, new List<IList<(int, int)>>());
                sortedDict[val].Add(points);
            }
            

        int[] rowMax = new int[matrix.Length],
            columnMax = new int[matrix[0].Length];
        
        
        foreach (var kv in sortedDict)
            foreach (var points in kv.Value)
            {
                var rank = 1;
                foreach (var (x, y) in points)
                    rank = Math.Max(rank,
                                   Math.Max(rowMax[x], columnMax[y]) + 1);
                foreach (var (x, y) in points)
                {
                    result[x][y] = rank;
                    rowMax[x] = Math.Max(rowMax[x], rank);
                    columnMax[y] = Math.Max(columnMax[y], rank);
                }
            }
        
        return result;
    }
}
// @lc code=end

