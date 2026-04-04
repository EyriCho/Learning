/*
 * @lc app=leetcode id=1622 lang=csharp
 *
 * [1622] Fancy Sequence
 */

// @lc code=start
public class Fancy {
    
    private const int mod = 1_000_000_007;

    private List<long> v;
    private long a;
    private long b;

    public Fancy() {
        v = new ();
        a = 1L;
        b = 0L;
    }

    private long QuickMul(long x, long y)
    {
        long rst = 1L,
            cur = x;
        while (y != 0) {
            if ((y & 1) != 0)
            {
                rst = rst * cur % mod;
            }
            cur = cur * cur % mod;
            y >>= 1;
        }
        return rst;
    }

    private long Inverse(long x)
    {
        return QuickMul(x, mod - 2);
    }
    
    public void Append(int val) {
        v.Add((val - b + mod) * Inverse(a) % mod);
    }
    
    public void AddAll(int inc) {
        b = (b + inc) % mod;
    }
    
    public void MultAll(int m) {
        a = a * m % mod;
        b = b * m % mod;
    }
    
    public int GetIndex(int idx) {
        if (idx >= v.Count)
        {
            return -1;
        }

        return (int)((a * v[idx] + b) % mod);
    }
}

/**
 * Your Fancy object will be instantiated and called as such:
 * Fancy obj = new Fancy();
 * obj.Append(val);
 * obj.AddAll(inc);
 * obj.MultAll(m);
 * int param_4 = obj.GetIndex(idx);
 */
// @lc code=end

