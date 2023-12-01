/*
 * @lc app=leetcode id=1441 lang=csharp
 *
 * [1441] Build an Array With Stack Operations
 */

// @lc code=start
public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        int i = 1,
            t = 0;

        List<string> result = new ();
        while (t < target.Length)
        {
            while (i <= n && i != target[t])
            {
                result.Add("Push");
                result.Add("Pop");
                i++;
            }

            result.Add("Push");
            i++;

            t++;
        }

        return result;
    }
}
// @lc code=end

