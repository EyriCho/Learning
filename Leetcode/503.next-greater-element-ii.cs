/*
 * @lc app=leetcode id=503 lang=csharp
 *
 * [503] Next Greater Element II
 */

// @lc code=start
public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var digits = new List<byte>();
        
        byte digit = 0, last = 0;
        long num = n;
        while (num > 0)
        {
            digit = (byte)(num % 10);
            if (digit < last)
                break;
            
            digits.Add(digit);
            last = digit;
            num /= 10;
        }
        
        if (num <= 0)
            return -1;
        
        num = num / 10 * 10;
        int pos = 1;
        digits.Sort();
        
        foreach (var d in digits)
        {
            if (d <= digit)
            {
                num = num * 10 + d;
                pos *= 10;
            }
            else
            {
                num = num * 10 + digit + pos * 10 * d;
                digit = 10;
            }
        }
        if (num > int.MaxValue)
            return -1;
        
        return (int)num;
    }
}
// @lc code=end

