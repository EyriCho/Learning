/*
 * @lc app=leetcode id=1663 lang=csharp
 *
 * [1663] Smallest String With A Given Numeric Value
 */

// @lc code=start
public class Solution {
    public string GetSmallestString(int n, int k) {
        var array = new char[n];
        
        for (int i = n - 1; i >= 0; i--)
        {
            int x = Math.Min(k - i, 26);
            array[i] = (char)('a' + x - 1);
            k -= x;
        }
        
        return new string(array);
    }
}
// @lc code=end

