/*
 * @lc app=leetcode id=954 lang=csharp
 *
 * [954] Array of Doubled Pairs
 */

// @lc code=start
public class Solution {
    public bool CanReorderDoubled(int[] arr) {
        var array = new int[200_001];
        
        foreach (var num in arr)
            array[num + 100_000]++;
        
        for (int i = -100_000; i < 100_001; i++)
        {
            var index = i + 100_000;
            if (i < 0)
            {
                if (array[index] == 0)
                    continue;
                
                if ((i & 1) > 0)
                    return false;
                
                int prev = i / 2 + 100_000;
                if (array[prev] < array[index])
                    return false;
                else
                    array[prev] -= array[index];
            }
            else if (i > 0)
            {
                if (array[index] == 0)
                    continue;
                
                if (i > 50000)
                    return false;
                
                int next = i * 2 + 100_000;
                if (array[next] < array[index])
                    return false;
                else
                    array[next] -= array[index];
            }
            else
            {
                if ((array[index] & 1) > 0)
                    return false;
            }
        }
        
        return true;
    }
}
// @lc code=end

