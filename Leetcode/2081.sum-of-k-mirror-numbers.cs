/*
 * @lc app=leetcode id=2081 lang=csharp
 *
 * [2081] Sum of k-Mirror Numbers
 */

// @lc code=start
public class Solution {
    public long KMirror(int k, int n) {
        bool IsKPalindrome(long num)
        {
            List<int> list = new ();
            while (num > 0L)
            {
                list.Add((int)(num % k));
                num /= k;
            }

            int l = 0, r = list.Count - 1;
            while (l < r)
            {
                if (list[l++] != list[r--])
                {
                    return false;
                }
            }

            return true;
        }

        int digit = 1, count = 0;
        long start = 0L, end = 0L,
            curr = 0L, reve = 0L,
            result = 0L;
        while (true)
        {
            if (digit == 1)
            {
                start = 0L;
                end = 1L;
            }
            else
            {
                start = (long)Math.Pow(10, (digit >> 1) - 1);
                end = (long)Math.Pow(10, digit >> 1);
            }

            for (long i = start; i < end; i++)
            {
                curr = i;
                reve = 0L;
                while (curr > 0)
                {
                    reve = reve * 10L + curr % 10L;
                    curr /= 10L;
                }

                curr = i * end * ((digit & 1) == 1 ? 10L : 1L) + reve;
                if ((digit & 1) == 0)
                {
                    if (IsKPalindrome(curr))
                    {
                        result += curr;
                        count++;
                        if (count == n)
                        {
                            return result;
                        }
                    }
                    continue;
                }

                for (int j = 0; j < 10; j++)
                {
                    if (digit == 1 && j == 0)
                    {
                        continue;
                    }
                    if (IsKPalindrome(curr + j * end))
                    {
                        result += curr + j * end;
                        count++;
                        if (count == n)
                        {
                            return result;
                        }
                    }
                }
            }

            digit++;
        }

        return result;
    }
}
// @lc code=end

