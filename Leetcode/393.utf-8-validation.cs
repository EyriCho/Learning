/*
 * @lc app=leetcode id=393 lang=csharp
 *
 * [393] UTF-8 Validation
 */

// @lc code=start
public class Solution {
    public bool ValidUtf8(int[] data) {
        int i = 0;
        
        while (i < data.Length)
        {
            if ((data[i] & 128) == 0)
            {
                i++;
                continue;
            }
            else
            {
                int remain = 0;
                if ((data[i] & 224) == 192)
                {
                    remain = 1;
                }
                else if ((data[i] & 240) == 224)
                {
                    remain = 2;
                }
                else if ((data[i] & 248) == 240)
                {
                    remain = 3;
                }
                else
                {
                    return false;
                }
                
                if (data.Length <= i + remain)
                {
                    return false;
                }
                
                for (; remain > 0; remain--)
                {
                    i++;
                    if ((data[i] & 192) != 128)
                    {
                        return false;
                    }
                }
                i++;
            }
        }
        
        return true;
    }
}
// @lc code=end

