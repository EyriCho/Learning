/*
 * @lc app=leetcode id=1361 lang=csharp
 *
 * [1361] Validate Binary Tree Nodes
 */

// @lc code=start
public class Solution {
    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild) {
        var parent = new int[n];
        Array.Fill(parent, -1);

        for (int i = 0; i < n; i++)
        {
            if (leftChild[i] != -1)
            {
                if (parent[leftChild[i]] != -1)
                {
                    return false;
                }
                parent[leftChild[i]] = i;
            }

            if (rightChild[i] != -1)
            {
                if (parent[rightChild[i]] != -1)
                {
                    return false;
                }
                parent[rightChild[i]] = i;
            }
        }

        var root = -1;
        for (int i = 0; i < n; i++)
        {
            if (parent[i] == -1)
            {
                if (root == -1)
                {
                    root = i;
                }
                else
                {
                    return false;
                }
            }
        }

        if (root == -1)
        {
            return false;
        }

        int Dfs(int node)
        {
            if (node == -1)
            {
                return 0;
            }

            return 1 + Dfs(leftChild[node]) + Dfs(rightChild[node]);
        }

        return Dfs(root) == n;
    }
}
// @lc code=end

