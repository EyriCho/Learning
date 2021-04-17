/*
 * @lc app=leetcode id=923 lang=csharp
 *
 * [923] 3Sum With Multiplicity
 */

// @lc code=start
public class Solution {
    public int ThreeSumMulti(int[] arr, int target) {
        var counts = new long[101];
        foreach (var num in arr)
            counts[num]++;
        
        long result = 0;
        for (int i = 0; i <= 100; i++)
        {
            if (counts[i] == 0)
                continue;
            for (int j = i; j <= 100; j++)
            {
                if (counts[j] == 0)
                    continue;
                
                int left = target - i - j;
                if (left < j)
                    break;
                if (left > 100)
                    continue;
                if (counts[left] == 0)
                    continue;
                
                if (left == i && left == j)
                {
                    if (counts[left] > 2)
                    {
                        result += (counts[i] - 2) * (counts[i] - 1) * counts[i] / 6;
                    }
                }
                else if (i == j)
                {
                    result += (counts[i] - 1) * counts[i] / 2 * counts[left];
                }
                else if (left == i)
                {
                    result += (counts[left] - 1) * counts[left] / 2 * counts[j];
                }
                else if (left == j)
                {
                    result += (counts[left] - 1) * counts[left] / 2 * counts[i];
                }
                else
                    result += counts[left] * counts[i] * counts[j];
            }
            
            result %= 1_000_000_007;
            if (i > target / 3)
                break;
        }
        
        return (int)result;
    }
}
// @lc code=end

