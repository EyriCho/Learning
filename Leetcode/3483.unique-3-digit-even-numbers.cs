/*
 * @lc app=leetcode id=3483 lang=csharp
 *
 * [3483] Unique 3-Digit Even Numbers
 */

// @lc code=start
public class Solution {
    public int TotalNumbers(int[] digits) {
        bool[] buckets = new bool[1000];
        int result = 0,
            num = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            for (int j = i + 1; j < digits.Length; j++)
            {
                for (int k = j + 1; k < digits.Length; k++)
                {
                    if (digits[i] != 0)
                    {
                        num = digits[i] * 100 + digits[j] * 10 + digits[k];

                        if ((digits[k] & 1) == 0 && !buckets[num])
                        {
                            buckets[num] = true;
                            result++;
                        }
                        
                        num = digits[i] * 100 + digits[k] * 10 + digits[j];

                        if ((digits[j] & 1) == 0 && !buckets[num])
                        {
                            buckets[num] = true;
                            result++;
                        }
                    }

                    if (digits[j] != 0)
                    {
                        num = digits[j] * 100 + digits[i] * 10 + digits[k];

                        if ((digits[k] & 1) == 0 && !buckets[num])
                        {
                            buckets[num] = true;
                            result++;
                        }
                        
                        num = digits[j] * 100 + digits[k] * 10 + digits[i];

                        if ((digits[i] & 1) == 0 && !buckets[num])
                        {
                            buckets[num] = true;
                            result++;
                        }
                    }

                    if (digits[k] != 0)
                    {
                        num = digits[k] * 100 + digits[i] * 10 + digits[j];

                        if ((digits[j] & 1) == 0 && !buckets[num])
                        {
                            buckets[num] = true;
                            result++;
                        }
                        
                        num = digits[k] * 100 + digits[j] * 10 + digits[i];

                        if ((digits[i] & 1) == 0 && !buckets[num])
                        {
                            buckets[num] = true;
                            result++;
                        }
                    }
                }
            }
        }

        return result;
    }
}
// @lc code=end

