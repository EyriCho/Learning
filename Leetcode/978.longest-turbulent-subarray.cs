/*
 * @lc app=leetcode id=978 lang=csharp
 *
 * [978] Longest Turbulent Subarray
 */

// @lc code=start
public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        if (arr.Length == 1)
            return 1;
        
        int result = 1, count = 1;
        var isEvenGreater = arr[0] < arr[1];
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                if ((i & 1) == 1 && isEvenGreater)
                    result = Math.Max(result, ++count);
                else if ((i & 1) == 0 && !isEvenGreater)
                    result = Math.Max(result, ++count);
                else
                {
                    isEvenGreater = (i & 1) == 1;
                    count = 2;
                }
            }
            else if (arr[i] < arr[i - 1])
            {
                if ((i & 1) == 1 && !isEvenGreater)
                    result = Math.Max(result, ++count);
                else if ((i & 1) == 0 && isEvenGreater)
                    result = Math.Max(result, ++count);
                else
                {
                    isEvenGreater = (i & 1) == 0;
                    count = 2;
                }
            }
            else
                count = 1;
        }
        
        return result;
    }
}
// @lc code=end

