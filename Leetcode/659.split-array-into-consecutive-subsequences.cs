/*
 * @lc app=leetcode id=659 lang=csharp
 *
 * [659] Split Array into Consecutive Subsequences
 */

// @lc code=start
public class Solution {
    public bool IsPossible(int[] nums) {
        Dictionary<int, int>
            freq = new Dictionary<int, int>(),
            tail = new Dictionary<int, int>();
        
        foreach (var num in nums)
        {
            if (freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
            {
                freq[num] = 1;
            }
        }
        
        foreach (var num in nums)
        {
            if (freq[num] == 0)
            {
                continue;
            }
            else if (tail.ContainsKey(num) && tail[num] > 0)
            {
                freq[num]--;
                tail[num]--;
                if (!tail.ContainsKey(num + 1))
                {
                    tail[num + 1] = 0;
                }
                tail[num + 1]++;
            }
            else if (freq.ContainsKey(num + 1) && freq[num + 1] > 0 &&
                freq.ContainsKey(num + 2) && freq[num + 2] > 0)
            {
                freq[num]--;
                freq[num + 1]--;
                freq[num + 2]--;
                if (!tail.ContainsKey(num + 3))
                {
                    tail[num + 3] = 0;
                }
                tail[num + 3]++;
            }
            else
            {
                Console.WriteLine(num);
                return false;
            }
        }
        
        return true;
    }
}
// @lc code=end

