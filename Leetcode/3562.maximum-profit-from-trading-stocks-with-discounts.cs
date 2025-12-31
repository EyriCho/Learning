/*
 * @lc app=leetcode id=3562 lang=csharp
 *
 * [3562] Maximum Profit from Trading Stocks with Discounts
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int n, int[] present, int[] future, int[][] hierarchy, int budget) {
        List<int>[] map = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            map[i] = new ();
        }

        foreach (int[] h in hierarchy)
        {
            map[h[0] - 1].Add(h[1] - 1);
        }

        int[] MergeBudget(int[] a, int[] b)
        {
            int[] rst = new int[budget + 1];
            Array.Fill(rst, int.MinValue / 2);

            for (int i = 0; i <= budget; i++)
            {
                if (a[i] < 0)
                {
                    continue;
                }

                for (int j = 0; i + j <= budget; j++)
                {
                    rst[i + j] = Math.Max(rst[i + j], a[i] + b[j]);
                }
            }
            return rst;
        }

        int[,][] dp = new int[n, 2][];
        void Dfs(int u)
        {
            foreach (int employee in map[u])
            {
                Dfs(employee);
            }

            int price = 0,
                profit = 0;
            for (int parentBought = 0; parentBought < 2; parentBought++)
            {
                price = parentBought == 1 ? present[u] / 2 : present[u];
                profit = future[u] - price;

                int[] skip = new int[budget + 1];
                foreach (int v in map[u])
                {
                    skip = MergeBudget(skip, dp[v, 0]);
                }

                int[] take = new int[budget + 1];
                Array.Fill(take, int.MinValue / 2);

                if (price <= budget)
                {
                    int[] basement = new int[budget + 1];
                    foreach (int v in map[u])
                    {
                        basement = MergeBudget(basement, dp[v, 1]);
                    }

                    for (int b = price; b <= budget; b++)
                    {
                        take[b] = basement[b - price] + profit;
                    }
                }

                dp[u, parentBought] = new int[budget + 1];
                for (int b = 0; b <= budget; b++)
                {
                    dp[u, parentBought][b] = Math.Max(skip[b], take[b]);
                }
            }
        }

        Dfs(0);

        int result = 0;
        for (int b = 0; b <= budget; b++)
        {
            result = Math.Max(result, dp[0, 0][b]);
        }

        return result;
    }
}
// @lc code=end

