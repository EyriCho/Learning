/*
 * @lc app=leetcode id=763 lang=csharp
 *
 * [763] Partition Labels
 */

// @lc code=start
public class Solution {
    public IList<int> PartitionLabels(string S) {
        var end = new int[26];
        for (int i = 0; i < S.Length; i++)
        {
            var index = (int)(S[i] - 'a');
            end[index] = i;
        }
        
        var result = new List<int>();
        var start = 0;
        var last = -1;
        for (int i = 0; i < S.Length; i++)
        {
            var index = (int)(S[i] - 'a');
            if (end[index] > last)
            {
                last = end[index];
            }
            
            if (last == i)
            {
                result.Add(i + 1 - start);
                start = i + 1;
            }
        }
        return result;
    }
}
// @lc code=end

