/*
 * @lc app=leetcode id=2246 lang=csharp
 *
 * [2246] Longest Path With Different Adjacent Characters
 */

// @lc code=start
public class Solution {
    public int LongestPath(int[] parent, string s) {
        var result = 1;
        
        var childs = new List<int>[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            childs[i] = new List<int>();
        }

        for (int i = 1; i < s.Length; i++)
        {
            childs[parent[i]].Add(i);
        }

        int Travel(int node)
        {
            int top1 = 0, top2 = 0;

            foreach (var child in childs[node])
            {
                int l = Travel(child);

                if (s[child] != s[node])
                {
                    if (l > top1)
                    {
                        top2 = top1;
                        top1 = l;
                    }
                    else if (l > top2)
                    {
                        top2 = l;
                    }
                }
            }

            result = Math.Max(result, top1 + top2 + 1);

            return top1 + 1;
        }

        Travel(0);

        return result;
    }
}
// @lc code=end

