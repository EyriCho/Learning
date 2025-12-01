/*
 * @lc app=leetcode id=3003 lang=csharp
 *
 * [3003] Maximize the Number of Partitions After Operations
 */

// @lc code=start
public class Solution {
    public int MaxPartitionsAfterOperations(string s, int k) {
        (int Partition, int Mask, int Count)[]
            prefix = new (int, int, int)[s.Length],
            suffix = new (int, int, int)[s.Length];

        int mask = 0,
            bit = 0,
            part = 0,
            count = 0;
        
        for (int i = 1; i < s.Length; i++)
        {
            bit = 1 << (s[i - 1] - 'a');
            if ((mask & bit) == 0)
            {
                count++;
                if (count <= k)
                {
                    mask |= bit;
                }
                else
                {
                    part++;
                    mask = bit;
                    count = 1;
                }
            }
            prefix[i] = (part, mask, count);
        }

        mask = 0;
        bit = 0;
        part = 0;
        count = 0;
        for (int i = s.Length - 2; i >= 0; i--)
        {
            bit = 1 << (s[i + 1] - 'a');
            if ((mask & bit) == 0)
            {
                count++;
                if (count <= k)
                {
                    mask |= bit;
                }
                else
                {
                    part++;
                    mask = bit;
                    count = 1;
                }
            }
            suffix[i] = (part, mask, count);
        }

        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            part = prefix[i].Partition + suffix[i].Partition + 2;
            mask = prefix[i].Mask | suffix[i].Mask;
            bit = BitOperations.PopCount((uint)mask);
            if (prefix[i].Count == k && suffix[i].Count == k && bit < 26)
            {
                part++;
            }
            else if (Math.Min(bit + 1, 26) <= k)
            {
                part--;
            }
            result = Math.Max(result, part);
        }
        return result;
    }
}
// @lc code=end

