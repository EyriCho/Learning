/*
 * @lc app=leetcode id=3501 lang=csharp
 *
 * [3501] Maximize Active Section with Trade II
 */

// @lc code=start
public class Solution {
    public IList<int> MaxActiveSectionsAfterTrade(string s, int[][] queries) {
        List<(int start, int len, int end)> zeroBlocks = new ();
        int oneCount = 0,
            left = 0, i = 0;
        while (i < s.Length)
        {
            left = i;
            while (i < s.Length && s[i] == s[left])
            {
                i++;
            }
            
            if (s[left] == '0')
            {
                zeroBlocks.Add((left, i - left, i - 1));
            }
            else
            {
                oneCount += i - left;
            }
        }

        if (zeroBlocks.Count < 2)
        {
            return Enumerable.Repeat(oneCount, queries.Length).ToList();
        }

        int[] tempSum = new int[zeroBlocks.Count - 1];
        for (i = 0; i < tempSum.Length; i++)
        {
            tempSum[i] = zeroBlocks[i].len + zeroBlocks[i + 1].len;
        }

        List<List<int>> st = new ();
        List<int> prev = new (tempSum),
            curr = null;
        st.Add(prev);
        i = 1;
        while (2 * i <= tempSum.Length + 1)
        {
            curr = new ();
            for (int j = 0; j < tempSum.Length - 2 * i + 1; j++)
            {
                curr.Add(Math.Max(prev[j], prev[j + i]));
            }
            st.Add(curr);
            prev = curr;
            i <<= 1;
        }

        int Query(int begin, int end)
        {
            if (begin > end)
            {
                return 0;
            }

            int length = end - begin + 1;
            int lg = (int)Math.Log2(length);
            return Math.Max(st[lg][begin], st[lg][end - (1 << lg) + 1]);
        }

        int LowerBound(int idx)
        {
            int l = 0, r = zeroBlocks.Count,
                m = 0;
            while (l < r)
            {
                m = (l + r) >> 1;
                if (zeroBlocks[m].end < idx)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            return l;
        }

        int UpperBound(int idx)
        {
            int l = 0, r = zeroBlocks.Count,
                m = 0;
            while (l < r)
            {
                m = (l + r) >> 1;
                if (zeroBlocks[m].start <= idx)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            return l;
        }

        List<int> result = new ();
        int lIdx = 0, rIdx = 0,
            firstLen = 0, lastLen = 0,
            best = 0;
        foreach (int[] query in queries)
        {
            lIdx = LowerBound(query[0]);
            rIdx = UpperBound(query[1]) - 1;

            if (lIdx >= zeroBlocks.Count ||
                rIdx < 0 ||
                lIdx >= rIdx)
            {
                result.Add(oneCount);
                continue;
            }

            firstLen = zeroBlocks[lIdx].end - Math.Max(zeroBlocks[lIdx].start, query[0]) + 1;
            lastLen = Math.Min(zeroBlocks[rIdx].end, query[1]) - zeroBlocks[rIdx].start + 1;
            best = 0;
            if (lIdx + 1 == rIdx)
            {
                best = firstLen + lastLen;
            }
            else
            {
                best = Math.Max(firstLen + zeroBlocks[lIdx + 1].len,
                    zeroBlocks[rIdx - 1].len + lastLen);
                best = Math.Max(best,
                    Query(lIdx + 1, rIdx - 2));
            }
            result.Add(best + oneCount);
        }

        return result;
    }
}
// @lc code=end

