/*
 * @lc app=leetcode id=2601 lang=csharp
 *
 * [2601] Prime Subtraction Operation
 */

// @lc code=start
public class Solution {
    public bool PrimeSubOperation(int[] nums) {
        bool[] primes = new bool[1_001];

        for (int p = 2; p < 1_001; p++)
        {
            if (primes[p])
            {
                continue;
            }

            for (int mul = p + p; mul < 1_001; mul += p)
            {
                primes[mul] = true;
            }
        }

        for (int j = nums[0] - 1; j > 1; j--)
        {
            if (!primes[j])
            {
                nums[0] -= j;
                break;
            }
        }


        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] >= nums[i])
            {
                return false;
            }

            for (int j = nums[i]; j > 1; j--)
            {
                if (!primes[j] &&
                    j < nums[i] - nums[i - 1])
                {
                    nums[i] -= j;
                    break;
                }
            }
        }

        return true;
    }
}
// @lc code=end

