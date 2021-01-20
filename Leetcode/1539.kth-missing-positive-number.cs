/*
 * @lc app=leetcode id=1539 lang=csharp
 *
 * [1539] Kth Missing Positive Number
 */

// @lc code=start
public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        if (k < arr[0])
            return k;
        
        int cur = 1;
        int missing = 0;        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != cur)
            {
                var m = arr[i] - cur;
                if (m + missing >= k)
                    return cur + k - missing - 1;
                else
                {
                    missing += m;
                    cur = arr[i];
                }
            }
            
            cur++;
        }
        return cur + k - missing - 1;
    }
}
// @lc code=end

