/*
 * @lc app=leetcode id=2322 lang=csharp
 *
 * [2322] Minimum Score After Removals on a Tree
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int>[] maps = new List<int>[nums.Length];
        List<int>[] childs = new List<int>[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            maps[i] = new ();
            childs[i] = new ();
        }
        foreach (int[] edge in edges)
        {
            maps[edge[0]].Add(edge[1]);
            maps[edge[1]].Add(edge[0]);
        }

        int[] xors = new int[nums.Length];
        void Dfs(int parent, int current)
        {
            childs[current].Add(current);
            xors[current] = nums[current];

            foreach (int next in maps[current])
            {
                if (next == parent)
                {
                    continue;
                }

                Dfs(current, next);
                xors[current] ^= xors[next];
                childs[current].AddRange(childs[next]);
            }
        }
        Dfs(-1, 0);

        int total = xors[0],
            result = int.MaxValue;
        
        int max = 0,
            a = 0, b = 0, c = 0,
            min = 0;
        for (int l = 1; l < nums.Length; l++)
        {
            for (int r = l + 1; r < nums.Length; r++)
            {
                if (childs[l].Contains(r))
                {
                    a = total ^ xors[l];
                    b = xors[l] ^ xors[r];
                    c = xors[r];
                }
                else if (childs[r].Contains(l))
                {
                    a = total ^ xors[r];
                    b = xors[r] ^ xors[l];
                    c = xors[l];
                }
                else
                {
                    a = total ^ xors[l] ^ xors[r];
                    b = xors[l];
                    c = xors[r];
                }

                min = Math.Min(a, Math.Min(b, c));
                max = Math.Max(a, Math.Max(b, c));
                result = Math.Min(result, max - min);
            }
        }

        return result;
    }
}
// @lc code=end

