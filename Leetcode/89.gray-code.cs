/*
 * @lc app=leetcode id=89 lang=csharp
 *
 * [89] Gray Code
 */

// @lc code=start
public class Solution {
    public IList<int> GrayCode(int n) {
        int count = 1 << n;
        var result = new int[count];
        int i = 1;
        
        for (int bitPos = 0; bitPos < n; bitPos++)
        {
            var mask = 1 << bitPos;
            for (int k = i - 1; k >= 0; k--)
                result[i++] = mask + result[k];
        }
        
        return result;
    }
}
// @lc code=end

