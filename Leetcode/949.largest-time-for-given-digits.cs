/*
 * @lc app=leetcode id=949 lang=csharp
 *
 * [949] Largest Time for Given Digits
 */

// @lc code=start
public class Solution {
    public string LargestTimeFromDigits(int[] arr) {
        int hour = -1, minute = -1;
        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j)
                    continue;
                for (int k = 0; k < 4; k++)
                {
                    if (i == k || j == k)
                        continue;
                    
                    var h = A[i] * 10 + A[j];
                    var m = A[k] * 10 + A[6 - i - j - k];
                    // check if the time is valid
                    if (h < 24 && m < 60)
                    {
                        if (h > hour)
                        {
                            hour = h;
                            minute = m;
                        }
                        else if (h == hour && m > minute)
                        {
                            minute = m;
                        }
                    }
                }
            }
        }
        
        if (hour > -1)
            return $"{hour:00}:{minute:00}";
        return string.Empty;
    }
}
// @lc code=end

