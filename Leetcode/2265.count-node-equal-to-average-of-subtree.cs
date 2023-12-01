/*
 * @lc app=leetcode id=2265 lang=csharp
 *
 * [2265] Count Node Equal to Average of Subtree
 */

// @lc code=start
public class Solution {
    public int AverageOfSubtree(TreeNode root) {
        int result = 0;

        (int, int) Average(TreeNode node)
        {
            if (node == null)
            {
                return (0, 0);
            }

            var (leftSum, leftCount) = Average(node.left);
            var (rightSum, rightCount) = Average(node.right);

            int sum = leftSum + rightSum + node.val,
                count = leftCount + rightCount + 1;
            
            if (sum / count == node.val)
            {
                result++;
            }

            return (sum, count);
        }

        Average(root);

        return result;
    }
}
// @lc code=end

