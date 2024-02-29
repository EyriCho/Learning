/*
 * @lc app=leetcode id=2709 lang=csharp
 *
 * [2709] Greatest Common Divisor Traversal
 */

// @lc code=start
public class Solution {
    public bool CanTraverseAllPairs(int[] nums) {
        int[] group = new int[nums.Length];
        for (int i = 1; i < nums.Length; i++)
        {
            group[i] = i;
        }

        int Find(int num)
        {
            if (group[num] != num)
            {
                group[num] = Find(group[num]);
            }

            return group[num];
        }

        IList<int> PrimeFactors(int num)
        {
            List<int> rst = new ();
            for (int i = 2; i * i <= num; i++)
            {
                while (num % i == 0)
                {
                    rst.Add(i);
                    num /= i;
                }
            }
            if (num > 1)
            {
                rst.Add(num);
            }
            return rst;
        }

        Dictionary<int, int> primeIndex = new();

        for (int i = 0; i < nums.Length; i++)
        {
            IList<int> primes = PrimeFactors(nums[i]);
            foreach (int prime in primes)
            {
                if (!primeIndex.ContainsKey(prime))
                {
                    primeIndex[prime] = i;
                }
                else
                {
                    int iGroup = Find(i),
                        pGroup = Find(primeIndex[prime]);
                    if (iGroup != pGroup)
                    {
                        group[iGroup] = pGroup;
                    }
                }
            }
        }

        int group0 = Find(0);
        for (int i = 1; i < nums.Length; i++)
        {
            if (Find(i) != group0)
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

