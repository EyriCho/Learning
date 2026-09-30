/*
 * @lc app=leetcode id=1111 lang=csharp
 *
 * [1111] Maximum Nesting Depth of Two Valid Parentheses Strings
 */

// @lc code=start
public class Solution {
    public int[] MaxDepthAfterSplit(string seq) {
        int[] result = new int[seq.Length];
        int depthA = 0,
            depthB = 0;
        
        for (int i = 0; i < seq.Length; i++)
        {
            if (seq[i] == '(')
            {
                if (depthA > depthB)
                {
                    result[i] = 1;
                    depthB++;
                }
                else
                {
                    result[i] = 0;
                    depthA++;
                }
            }
            else
            {
                if (depthA > depthB)
                {
                    result[i] = 0;
                    depthA--;
                }
                else
                {
                    result[i] = 1;
                    depthB--;
                }
            }
        }

        return result;
    }
}
// @lc code=end

