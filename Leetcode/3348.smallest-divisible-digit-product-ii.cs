/*
 * @lc app=leetcode id=3348 lang=csharp
 *
 * [3348] Smallest Divisible Digit Product II
 */

// @lc code=start
public class Solution {
    public string SmallestNumber(string num, long t) {
        long temp = t;
        for (int i = 9; i > 1; i--)
        {
            while (temp % i == 0)
            {
                temp /= i;
            }
        }
        if (temp > 1)
        {
            return "-1";
        }

        long Gcd(long a, long b)
        {
            long temp = 0L;
            while (b != 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }
            return a;
        }

        char[] array = num.ToCharArray();
        long[] rem = new long[num.Length + 1];
        rem[0] = t;
        int firstZero = num.Length - 1;
        for (int i = 0; i < num.Length; i++)
        {
            if (array[i] == '0')
            {
                firstZero = i;
                break;
            }

            rem[i + 1] = rem[i] / Gcd(rem[i], array[i] - '0');
        }

        if (rem[num.Length] == 1L)
        {
            return num;
        }

        long tCurrent = 0L;
        for (int i = firstZero; i >= 0; i--)
        {
            while (++array[i] <= '9')
            {
                tCurrent = rem[i] / Gcd(rem[i], array[i] - '0');
                int digit = 9;
                
                for (int j = num.Length - 1; j > i; j--)
                {
                    while (tCurrent % digit != 0)
                    {
                        digit--;
                    }

                    tCurrent /= digit;
                    array[j] = (char)(digit + '0');
                }

                if (tCurrent == 1L)
                {
                    return new string(array);
                }
            }
        }

        List<char> list = new ();
        for (int d = 9; d > 1; d--)
        {
            while (t % d == 0)
            {
                list.Add((char)(d + '0'));
                t /= d;
            }
        }

        int padding = Math.Max(num.Length + 1 - list.Count, 0);
        while (padding-- > 0)
        {
            list.Add('1');
        }

        list.Reverse();
        return new string(list.ToArray());
    }
}
// @lc code=end

