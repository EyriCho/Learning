/*
 * @lc app=leetcode id=2843 lang=csharp
 *
 * [2843] Count Symmetric Integers
 */

// @lc code=start
public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int count = 0,
            ab = 0,
            cd = 0;
        for (int i = low; i <= high; i++)
        {
            if (i < 10)
            {
                i = 10;
            }
            else if (i < 100)
            {
                if (i % 11 == 0)
                {
                    count++;
                    i += 10;
                }
            }
            else if (i < 1000)
            {
                i = 1000;
            }
            else
            {
                ab = i / 100;
                cd = i % 100;
                ab = ab / 10 + ab % 10;
                cd = cd / 10 + cd % 10;
                if (ab == cd)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
// @lc code=end

