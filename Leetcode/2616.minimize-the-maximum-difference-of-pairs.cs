/*
 * @lc app=leetcode id=2616 lang=csharp
 *
 * [2616] Minimize the Maximum Difference of Pairs
 */

// @lc code=start
public class Solution {
    public int MinimizeMax(int[] nums, int p) {
        if (p == 0)
        {
            return 0;
        }

        Array.Sort(nums);

        bool Check(int maxDiff)
        {
            var dp = new int[nums.Length + 1];
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i + 1] = dp[i];
                if (nums[i] - nums[i - 1] <= maxDiff)
                {
                    dp[i + 1] = Math.Max(dp[i + 1], dp[i - 1] + 1);
                }
            }

            return dp[nums.Length] >= p;
        }
        
        int l = 0,
            r = nums[nums.Length - 1] - nums[0],
            m = 0;

        while (l < r)
        {
            m = (l + r) >> 1;
            if (Check(m))
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }

        return r;
    }
        var reached = new Dictionary<string, bool>();
        reached[beginWord] = true;
        var wordDict = new Dictionary<string, bool>();
        foreach (var word in wordList)
            wordDict[word] = true;
        if (!wordDict.ContainsKey(endWord))
            return 0;
        
        int length = 1;
        while (!reached.ContainsKey(endWord))
        {
            var toAdd = new Dictionary<string, bool>();
            foreach (var reach in reached.Keys)
            {
                for (int i = 0; i < reach.Length; i++)
                {
                    var array = reach.ToCharArray();
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        array[i] = c;
                        string str = new String(array);
                        if (wordDict.ContainsKey(str))
                        {
                            toAdd[str] = true;
                            wordDict.Remove(str);
                        }
                    }
                }
            }
            length++;
            if (toAdd.Count == 0)
                return 0;
            reached = toAdd;
        }
        
        return length;
    }
}
// @lc code=end

