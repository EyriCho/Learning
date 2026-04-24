/*
 * @lc app=leetcode id=1722 lang=csharp
 *
 * [1722] Minimize Hamming Distance After Swap Operations
 */

// @lc code=start
public class Solution {
    public int MinimumHammingDistance(int[] source, int[] target, int[][] allowedSwaps) {
        int[] groups = new int[source.Length];
        for (int i = 0; i < groups.Length; i++)
        {
            groups[i] = i;
        }
        int FindGroup(int pos)
        {
            return groups[pos] = (groups[pos] == pos ? pos : FindGroup(groups[pos]));
        }
        
        int groupa = 0, groupb = 0,
            count = 0;
        foreach (int[] swap in allowedSwaps)
        {
            groupa = FindGroup(swap[0]);
            groupb = FindGroup(swap[1]);

            if (groupa == groupb)
            {
                continue;
            }
            else if (groupa < groupb)
            {
                groups[groupb] = groupa;
            }
            else
            {
                groups[groupa] = groupb;
            }
        }

        Dictionary<int, Dictionary<int, int>> groupDict = new ();
        for (int i = 0; i < source.Length; i++)
        {
            groupa = FindGroup(i);
            if (!groupDict.TryGetValue(groupa, out Dictionary<int, int> dict))
            {
                groupDict[groupa] = dict = new ();
            }
            
            dict.TryGetValue(source[i], out count);
            dict[source[i]] = count + 1;
        }

        for (int i = 0; i < target.Length; i++)
        {
            groupb = FindGroup(i);
            groupDict.TryGetValue(groupb, out Dictionary<int, int> dict);

            dict.TryGetValue(target[i], out count);
            if (count == 0)
            {
                continue;
            }
            dict[target[i]] = count - 1;
        }

        int result = 0;
        foreach (Dictionary<int, int> dict in groupDict.Values)
        {
            foreach (KeyValuePair<int, int> kv in dict)
            {
                result += kv.Value;
            }
        }

        return result;
    }
}
// @lc code=end

