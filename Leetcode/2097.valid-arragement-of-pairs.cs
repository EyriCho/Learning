/*
 * @lc app=leetcode id=2097 lang=csharp
 *
 * [2097] Valid Arragement of Pairs
 */

// @lc code=start
public class Solution {
    public int[][] ValidArrangement(int[][] pairs) {
        Dictionary<int, Stack<int>> map = new ();
        Dictionary<int, int> outDict = new ();
        int c = 0;
        for (int i = 0; i < pairs.Length; i++)
        {
            if (!map.TryGetValue(pairs[i][0], out Stack<int> stack))
            {
                map[pairs[i][0]] = stack = new();
            }
            stack.Push(pairs[i][1]);

            outDict.TryGetValue(pairs[i][0], out c);
            outDict[pairs[i][0]] = c + 1;
            outDict.TryGetValue(pairs[i][1], out c);
            outDict[pairs[i][1]] = c - 1;
        }

        int start = pairs[0][0];
        foreach (KeyValuePair<int, int> kv in outDict)
        {
            if (kv.Value == 1)
            {
                start = kv.Key;
            }
        }

        List<int[]> rst = new (pairs.Length);

        void Eular(int s)
        {
            map.TryGetValue(s, out Stack<int> stack);
            while (stack != null && stack.Count > 0)
            {
                int e = stack.Pop();
                Eular(e);
                rst.Add(new int[] { s, e });
            }
        }
        Eular(start);

        rst.Reverse();
        return rst.ToArray();
    }
}
// @lc code=end

