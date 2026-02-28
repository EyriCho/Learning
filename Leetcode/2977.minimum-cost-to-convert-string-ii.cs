/*
 * @lc app=leetcode id=2977 lang=csharp
 *
 * [2977] Minimum Cost to Convert String II
 */

// @lc code=start
public class Solution {

    internal class TreeNode {
        internal TreeNode[] Next;
        internal int Id;

        internal TreeNode()
        {
            Next = new TreeNode[26];
            Id = -1;
        }
    }

    public long MinimumCost(string source, string target, string[] original, string[] changed, int[] cost) {
        TreeNode root = new ();
        int idCount = 0;

        void AddNode(string str)
        {
            TreeNode node = root;
            int n = 0;
            foreach (char c in str)
            {
                n = c - 'a';
                if (node.Next[n] == null)
                {
                    node.Next[n] = new ();
                }

                node = node.Next[n];
            }

            if (node.Id == -1)
            {
                node.Id = idCount++;
            }
        }

        int GetId(string str)
        {
            TreeNode node = root;
            foreach (char c in str)
            {
                node = node.Next[c - 'a'];
            }
            return node.Id;
        }

        foreach (string s in original)
        {
            AddNode(s);
        }

        foreach (string s in changed)
        {
            AddNode(s);
        }

        long[][] maps = new long[idCount][];
        for (int i = 0; i < idCount; i++)
        {
            maps[i] = new long[idCount];
            Array.Fill(maps[i], long.MaxValue);
            maps[i][i] = 0L;
        }

        int xId = 0, yId = 0;
        for (int i = 0; i < original.Length; i++)
        {
            xId = GetId(original[i]);
            yId = GetId(changed[i]);

            maps[xId][yId] = Math.Min(maps[xId][yId], cost[i]);
        }

        for (int k = 0; k < idCount; k++)
        {
            for (int i = 0; i < idCount; i++)
            {
                if (maps[i][k] == long.MaxValue)
                {
                    continue;
                }

                for (int j = 0; j < idCount; j++)
                {
                    if (maps[k][j] == long.MaxValue)
                    {
                        continue;
                    }

                    maps[i][j] = Math.Min(maps[i][j], maps[i][k] + maps[k][j]);
                }
            }
        }

        long[] dp = new long[source.Length + 1];
        Array.Fill(dp, long.MaxValue);
        dp[0] = 0L;

        TreeNode xNode = null, yNode = null;
        for (int i = 0; i < source.Length; i++)
        {
            if (dp[i] == long.MaxValue)
            {
                continue;
            }

            if (source[i] == target[i])
            {
                dp[i + 1] = Math.Min(dp[i + 1], dp[i]);
            }

            xNode = root;
            yNode = root;

            for (int j = i; j < source.Length; j++)
            {
                xId = source[j] - 'a';
                yId = target[j] - 'a';

                xNode = xNode.Next[xId];
                yNode = yNode.Next[yId];

                if (xNode == null || yNode == null)
                {
                    break;
                }

                if (xNode.Id != -1 && yNode.Id != -1 &&
                    maps[xNode.Id][yNode.Id] != long.MaxValue)
                {
                    dp[j + 1] = Math.Min(dp[j + 1], dp[i] + maps[xNode.Id][yNode.Id]);
                }
            }
        }

        return dp[source.Length] == long.MaxValue ? -1 : dp[source.Length];
    }
}
// @lc code=end

