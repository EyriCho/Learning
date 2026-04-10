/*
 * @lc app=leetcode id=3655 lang=csharp
 *
 * [3655] XOR After Range Multiplication Queries II
 */

// @lc code=start
public class Solution {
    public int XorAfterQueries(int[] nums, int[][] queries) {
        const int mod = 1_000_000_007;
        int limit = (int) Math.Sqrt(nums.Length);

        Dictionary<int, IList<int[]>> lightDict = new ();

        foreach (int[] query in queries)
        {
            if (query[2] < limit)
            {
                if (!lightDict.TryGetValue(query[2], out IList<int[]> list))
                {
                    lightDict[query[2]] = list = new List<int[]>();
                }

                list.Add(query);
                continue;
            }

            for (int i = query[0]; i <= query[1]; i += query[2])
            {
                nums[i] = (int)((1L * nums[i] * query[3]) % mod);
            }
        }

        long ModInv(long num)
        {
            long rst = 1L;
            num %= mod;
            long exp = mod - 2;
            while (exp > 0)
            {
                if ((exp & 1) == 1)
                {
                    rst = (rst * num) % mod;
                }
                num = (num * num) % mod;
                exp >>= 1;
            }
            return rst;
        }

        long[] diff = new long[nums.Length];
        int steps = 0,
            last = 0;
        foreach (KeyValuePair<int, IList<int[]>> kv in lightDict)
        {
            Array.Fill(diff, 1L);

            foreach (int[] query in kv.Value)
            {
                diff[query[0]] = (diff[query[0]] * query[3]) % mod;

                steps = (query[1] - query[0]) / kv.Key;
                last = query[0] + (steps + 1) * kv.Key;
                if (last < nums.Length)
                {
                    diff[last] = (diff[last] * ModInv(query[3])) % mod;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i >= kv.Key)
                {
                    diff[i] = (diff[i] * diff[i - kv.Key]) % mod;
                }
                nums[i] = (int)((nums[i] * diff[i]) % mod);
            }
        }

        int result = 0;
        foreach (int num in nums)
        {
            result ^= num;
        }
        
        return result;
    }
}
// @lc code=end

