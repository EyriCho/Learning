/*
 * @lc app=leetcode id=241 lang=csharp
 *
 * [241] Different Ways to Add Parentheses
 */

// @lc code=start
public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        Dictionary<string, IList<int>> dict = new ();
        HashSet<char> ops = new () {
            '+', '-', '*',
        };

        IList<int> FindWays(string ex)
        {
            if (dict.ContainsKey(ex))
            {
                return dict[ex];
            }

            List<int> ways = new ();
            for (int i = 0; i < ex.Length; i++)
            {
                if (ops.Contains(ex[i]))
                {
                    foreach (int l in FindWays(ex[0..i]))
                    {
                        foreach (int r in FindWays(ex[(i + 1)..]))
                        {
                            if (ex[i] == '+')
                            {
                                ways.Add(l + r);
                            }
                            else if (ex[i] == '-')
                            {
                                ways.Add(l - r);
                            }
                            else
                            {
                                ways.Add(l * r);
                            }
                        }
                    }
                }
            }

            if (ways.Count == 0)
            {
                ways.Add(int.Parse(ex));
            }
            dict[ex] = ways;
            return ways;
        }

        return FindWays(expression);
    }
}
// @lc code=end

