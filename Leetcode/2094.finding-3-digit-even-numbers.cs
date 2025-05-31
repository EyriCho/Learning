/*
 * @lc app=leetcode id=2094 lang=csharp
 *
 * [2094] Finding 3-Digit Even Numbers
 */

// @lc code=start
public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        int[] ds = new int[10];
        foreach (int digit in digits)
        {
            ds[digit]++;
        }

        List<int> list = new ();

        for (int a = 1; a < 10; a++)
        {
            if (ds[a] <= 0)
            {
                continue;
            }

            for (int b = 0; b < 10; b++)
            {
                if (ds[b] - (a == b ? 1 : 0) <= 0)
                {
                    continue;
                }

                for (int c = 0; c < 10; c += 2)
                {
                    if (ds[c] - (a == c ? 1 : 0) - (b == c ? 1 : 0) <= 0)
                    {
                        continue;
                    }

                    list.Add(a * 100 + b * 10 + c);
                }
            }
        }

        return list.ToArray();
    }
}
// @lc code=end

