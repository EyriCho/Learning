/*
 * @lc app=leetcode id=587 lang=csharp
 *
 * [587] Erect the Fence
 */

// @lc code=start
public class Solution {
    public int[][] OuterTrees(int[][] trees) {
        if (trees.Length < 4)
            return trees;
        
        var list = new List<int[]>(trees.Length);
        var bottomLeft = trees[0];
        for (int i = 1; i < trees.Length; i++)
        {
            if (bottomLeft[1] > trees[i][1] ||
               (bottomLeft[1] == trees[i][1] && bottomLeft[0] > trees[i][0]))
            {
                list.Add(bottomLeft);
                bottomLeft = trees[i];
            }
            else
                list.Add(trees[i]);
        }
        
        var dict = new Dictionary<int[], (int, double)>();
        
        list.Sort((a, b) => {
            if (!dict.ContainsKey(a))
            {
                int xDiff = a[0] - bottomLeft[0],
                    yDiff = a[1] - bottomLeft[1];
                var dist = xDiff * xDiff + yDiff * yDiff;
                var cos = (double)(xDiff * xDiff) / dist;
                if (xDiff < 0)
                    cos = -cos;
                dict[a] = (dist, cos);
            }
            
            if (!dict.ContainsKey(b))
            {
                int xDiff = b[0] - bottomLeft[0],
                    yDiff = b[1] - bottomLeft[1];
                var dist = xDiff * xDiff + yDiff * yDiff;
                var cos = (double)xDiff * xDiff / dist;
                if (xDiff < 0)
                    cos = -cos;
                dict[b] = (dist, cos);                
            }
            
            if (dict[a].Item2 == dict[b].Item2)
                return dict[a].Item1 - dict[b].Item1;
            else
                return dict[b].Item2.CompareTo(dict[a].Item2);
        });
                
        int Site(int[] p, int[] q, int[] r)
        {
            return (q[0] - p[0]) * (r[1] - q[1]) - (q[1] - p[1]) * (r[0] - q[0]);
        }
        
        var stack = new Stack<int[]>();
        stack.Push(bottomLeft);
        var top = list[0];
        
        for (int j = 1; j < list.Count; j++)
        {
            while (Site(stack.Peek(), top, list[j]) < 0)
            {
                top = stack.Pop();
            }
            stack.Push(top);
            top = list[j];
        }
               
        stack.Push(top);
        
        if (stack.Count != trees.Length)
            for (int j = list.Count - 2; j >= 0; j--)
                if (Site(bottomLeft, top, list[j]) == 0)
                    stack.Push(list[j]);
                else
                    break;
        
        return stack.ToArray();
    }
}
// @lc code=end

