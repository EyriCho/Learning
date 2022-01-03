/*
 * @lc app=leetcode id=973 lang=csharp
 *
 * [973] K Closest Points to Origin
 */

// @lc code=start
public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var array = new (int, int, int)[k];
        var length = 0;
        void Add(int[] point, int dist)
        {
            int i = length++;
            while (i > 0)
            {
                var p = (i - 1) / 2;
                if (dist <= array[p].Item1)
                    break;
                
                array[i] = array[p];
                i = p;
            }
            array[i] = (dist, point[0], point[1]);
        }
        
        void Pop()
        {
            var s = array[--length];
            int i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;
                
                if (l >= length)
                    break;
                
                if (array[l].Item1 > s.Item1 ||
                    (r < length && array[r].Item1 > s.Item1))
                {
                    if (r >= length || array[l].Item1 > array[r].Item1)
                    {
                        array[i] = array[l];
                        i = l;
                    }
                    else
                    {
                        array[i] = array[r];
                        i = r;
                    }
                }
                else
                    break;
            }
            
            array[i] = s;
            return;
        }
        
        foreach (var point in points)
        {
            var dist = point[0] * point[0] + point[1] * point[1];
            if (length < k)
                Add(point, dist);
            else if (dist < array[0].Item1)
            {
                Pop();
                Add(point, dist);
            }
        }
        
        var result = new int[k][];
        for (int i = 0; i < k; i++)
            result[i] = new int[] { array[i].Item2, array[i].Item3 };
        return result;
    }
}
// @lc code=end

