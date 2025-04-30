/*
 * @lc app=leetcode id=781 lang=csharp
 *
 * [781] Rabbits in Forest
 */

// @lc code=start
public class Solution {
    public int NumRabbits(int[] answers) {
        Dictionary<int, int> dict = new ();
        int count = 0;
        foreach (int rabbit in answers)
        {
            dict.TryGetValue(rabbit + 1, out count);
            dict[rabbit + 1] = count + 1;
        }

        int result = 0;
        foreach (KeyValuePair<int, int> kv in dict)
        {
            result += (kv.Value % kv.Key == 0) ?
                kv.Value :
                (kv.Value / kv.Key + 1) * kv.Key;
        }

        return result;
    }
}
// @lc code=end

