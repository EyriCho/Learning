/*
 * @lc app=leetcode id=3600 lang=csharp
 *
 * [3600] Maximize Spanning Tree Stability with Upgrades
 */

// @lc code=start
public class Solution {
    public int MaxStability(int n, int[][] edges, int k) {
        DSU dsu = new (n);
        int min = 200_000, max = 1;
        foreach (int[] edge in edges)
        {
            if (edge[3] == 1 &&
                !dsu.Unite(edge[0], edge[1]))
            {
                return -1;
            }

            min = Math.Min(min, edge[2]);
            max = Math.Max(max, edge[2] * (edge[3] == 1 ? 1 : 2));
        }

        bool CanMakeIt(int stability)
        {
            DSU dsu = new (n);
            foreach (int[] edge in edges)
            {
                if (edge[3] == 1)
                {
                    if (edge[2] < stability)
                    {
                        return false;
                    }
                    if (!dsu.Unite(edge[0], edge[1]))
                    {
                        return false;
                    }
                }
            }

            foreach (int[] edge in edges)
            {
                if (edge[3] == 0 && edge[2] >= stability)
                {
                    dsu.Unite(edge[0], edge[1]);
                }
            }

            int upgrades = 0;
            foreach (int[] edge in edges)
            {
                if (edge[3] == 0 &&
                    edge[2] < stability && edge[2] * 2 >= stability)
                {
                    if (dsu.Unite(edge[0], edge[1]))
                    {
                        upgrades++;
                        if (upgrades > k)
                        {
                            return false;
                        }
                    }
                }
            }

            return dsu.IsAllUnited;
        }

        int result = -1,
            mid = 0;

        while (min <= max)
        {
            mid = min + ((max - min) >> 1);
            if (CanMakeIt(mid))
            {
                result = mid;
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        return result;
    }

    internal class DSU
    {
        private int[] array;
        private int groups;
        
        internal bool IsAllUnited => groups == 1;

        internal DSU(int count)
        {
            array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = i;
            }
            groups = count;
        }

        private int FindGroup(int a)
        {
            return array[a] = (array[a] == a ? a : FindGroup(array[a]));
        }

        internal bool Unite(int a, int b)
        {
            int ga = FindGroup(a),
                gb = FindGroup(b);
            
            if (ga == gb)
            {
                return false;
            }

            array[gb] = ga;
            groups--;
            return true;
        }
    }
}
// @lc code=end

