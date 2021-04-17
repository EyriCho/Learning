/*
 * @lc app=leetcode id=869 lang=csharp
 *
 * [869] Reordered Power of 2
 */

// @lc code=start
public class Solution {
    public bool ReorderedPowerOf2(int N) {
        int[] countDigit(int num)
        {
            var result = new int[10];
            while (num > 0)
            {
                result[num % 10]++;
                num /= 10;
            }
            return result;
        }
        
        bool match(int[] origin, int num)
        {
            var target = countDigit(num);
            int i = 0;
            while (i < 10)
            {
                if (origin[i] != target[i])
                    return false;
                
                i++;
            }
            return true;
        }
        
        int[] digits = countDigit(N);
        
        for (int i = 0; i < 32; i++)
        {
            if (match(digits, 1 << i))
                return true;
        }
        
        return false;
    }
}
// @lc code=end

