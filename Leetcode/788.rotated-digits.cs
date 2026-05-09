/*
 * @lc app=leetcode id=788 lang=csharp
 *
 * [788] Rotated Digits
 */

// @lc code=start
public class Solution {
    public int RotatedDigits(int n) {
        int result = 0,
            num = 0,
            digit = 0;
        bool required = false,
            exclude = false;
        for (int i = 1; i <= n; i++)
        {
            num = i;
            required = exclude = false;
            while (num > 0)
            {
                digit = num % 10;
                switch (digit)
                {
                    case 2:
                    case 5:
                    case 6:
                    case 9:
                        required = true;
                        break;
                    case 3:
                    case 4:
                    case 7:
                        exclude = true;
                        break;
                    default:
                        break;
                }
                num /= 10;
            }

            if (required && !exclude)
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

