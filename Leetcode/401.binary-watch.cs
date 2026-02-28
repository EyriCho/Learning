/*
 * @lc app=leetcode id=401 lang=csharp
 *
 * [401] Binary Watch
 */

// @lc code=start
public class Solution {
    public IList<string> ReadBinaryWatch(int turnedOn) {
        List<string> result = new ();

        int CountBits(int num)
        {
            int bits = 0;
            while (num > 0)
            {
                bits++;
                num &= num - 1;
            }

            return bits;
        }

        int hourBits = 0;
        for (int h = 0; h < 12; h++)
        {
            hourBits = CountBits(h);
            if (hourBits > turnedOn)
            {
                continue;
            }

            for (int m = 0; m < 60; m++)
            {
                if (CountBits(m) != turnedOn - hourBits)
                {
                    continue;
                }

                result.Add($"{h}:{m:00}");
            }
        }

        return result;
    }
}
// @lc code=end

