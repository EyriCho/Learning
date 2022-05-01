/*
 * @lc app=leetcode id=399 lang=csharp
 *
 * [399] Evaluate Division
 */

// @lc code=start
public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        var dict = new Dictionary<string, IList<(string, double)>>();
        
        for (int i = 0; i < values.Length; i++)
        {
            if (!dict.TryGetValue(equations[i][0], out IList<(string, double)> equateA))
            {
                dict[equations[i][0]] = equateA = new List<(string, double)>();
            }
            
            equateA.Add((equations[i][1], values[i]));
            
            if (!dict.TryGetValue(equations[i][1], out IList<(string, double)> equateB))
            {
                dict[equations[i][1]] = equateB = new List<(string, double)>();
            }
            
            equateB.Add((equations[i][0], 1 / values[i]));
        }
        
        double Query(string c, string d)
        {
            var visited = new HashSet<string>();
            var queue = new Queue<(string, double)>();
            queue.Enqueue((c, 1));
            
            while (queue.Count > 0)
            {
                var (variable, val) = queue.Dequeue();
                if (variable == d)
                {
                    return val;
                }

                if (visited.Contains(variable))
                {
                    continue;
                }
                
                visited.Add(variable);
                foreach (var (next, mul) in dict[variable])
                {
                    queue.Enqueue((next, val * mul));
                }
            }
            
            return -1D;
        }
        
        var result = new double[queries.Count];
        
        for (int i = 0; i < queries.Count; i++)
        {
            if (!dict.ContainsKey(queries[i][0]) || !dict.ContainsKey(queries[i][1]))
            {
                result[i] = -1D;
            }
            else if (queries[i][0] == queries[i][1])
            {
                result[i] = 1D;
            }
            else
            {
                result[i] = Query(queries[i][0], queries[i][1]);
            }
        }
        
        return result;
    }
}
// @lc code=end

