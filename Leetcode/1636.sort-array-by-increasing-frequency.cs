/*
 * @lc app=leetcode id=1636 lang=csharp
 *
 * [1636] Sort Array by Increasing Frequency
 */

// @lc code=start
public class Solution {
    public int[] FrequencySort(int[] nums) {
        int[] freq = new int[201];
        foreach (int num in nums)
        {
            freq[num + 100]++;
        }
        SortedDictionary<int, IList<int>> dict = new ();

        for (int i = 0; i < 201; i++)
        {
            if (freq[i] > 0)
            {
                if (!dict.TryGetValue(freq[i], out IList<int> list))
                {
                    dict[freq[i]] = list = new List<int>();
                }
                list.Add(i - 100);
            }
        }

        int index = 0;
        foreach (KeyValuePair<int, IList<int>> kv in dict)
        {
            foreach (int num in kv.Value.OrderByDescending(n => n))
            {
                int k = kv.Key;
                while (k-- > 0)
                {
                    nums[index++] = num;
                }
            }
        }

        return nums;
    }
}
// @lc code=end

