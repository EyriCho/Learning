/*
 * @lc app=leetcode id=3514 lang=csharp
 *
 * [3514] Number of Unique XOR Triplets II
 */

// @lc code=start
public class Solution {
    public int UniqueXorTriplets(int[] nums) {
        int max = nums.Max();
        int len = 32 - BitOperations.LeadingZeroCount((uint)max);
        int count = 1 << len,
            t = 0,
            result = 0;
        bool[] couple = new bool[count],
            triplet = new bool[count];
        couple[0] = true;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                couple[nums[i] ^ nums[j]] = true;
            }
        }

        for (int c = 0; c < count; c++)
        {
            if (!couple[c])
            {
                continue;
            }
            
            foreach (int num in nums)
            {
                t = c ^ num;

                if (!triplet[t])
                {
                    triplet[t] = true;
                    result++;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

