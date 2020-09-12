/*
 * @lc app=leetcode id=952 lang=csharp
 *
 * [952] Largest Component Size by Common Factor
 */

// @lc code=start
public class Solution {
    private int[] factor;
    
    private int findRoot(int a) {
        if (factor[a] == a)
            return a;
        factor[a] = findRoot(factor[a]);
        return factor[a];
    }

    public int LargestComponentSize(int[] A) {
        var max = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > max)
                max = A[i];
        }
        factor = new int[max + 1];
        for (int i = 1; i < max; i++)
        {
            factor[i] = i;
        }
        
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = (int)Math.Sqrt(A[i]); j >= 2; j--)
            {
                if (A[i] % j == 0)
                {
                    var rj = findRoot(j);
                    var ri = findRoot(A[i]);
                    if (ri != rj)
                        factor[ri] = factor[rj];
                    
                    ri = findRoot(A[i]);
                    rj = findRoot(A[i] / j);
                    if (ri != rj)
                        factor[ri] = factor[rj];
                }
            }
        }
        
        var count = new int[max + 1];
        var result = 0;
        foreach (var num in A)
        {
            var r = findRoot(num);
            var c = ++count[r];
            if (c > result)
                result = c;
        }
        return result;
    }
}
// @lc code=end

