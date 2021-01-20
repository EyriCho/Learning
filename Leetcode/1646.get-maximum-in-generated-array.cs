/*
 * @lc app=leetcode id=1646 lang=csharp
 *
 * [1646] Get Maximum in Generated Array
 */

// @lc code=start
public class Solution {
    public int GetMaximumGenerated(int n) {
        if (n < 2)
            return n;
        
        var array = new int[n + 1];
        array[1] = 1;
        int count = n / 2,
            result = 1;
        for (int i = 1; i <= count; i++)
        {
            array[i * 2] = array[i];
            var next = i * 2 + 1;
            if (next <= n)
            {
                array[next] = array[i] + array[i + 1];
                result = Math.Max(result, array[next]);
            }
        }
        
        return result;
    }
}
// @lc code=end

