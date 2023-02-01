/*
 * @lc app=leetcode id=352 lang=csharp
 *
 * [352] Data Stream as Disjoint Intervals
 */

// @lc code=start
public class SummaryRanges {

    private SortedSet<int> set;

    public SummaryRanges() {
        set = new SortedSet<int>();
    }
    
    public void AddNum(int value) {
        set.Add(value);
    }
    
    public int[][] GetIntervals() {
        var list = new List<int[]>();

        var start = set.First();
        var count = 0;
        var prev = start;

        foreach (var num in set)
        {
            if (num - start != count)
            {
                list.Add(new int[] { start, prev });
                start = num;
                count = 0;
            }

            prev = num;
            count++;
        }

        count--;
        if (prev - count == start)
        {
            list.Add(new int[] { start, prev });
        }
        else
        {
            list.Add(new int[] { prev, prev });
        }

        return list.ToArray();
    }
}

/**
 * Your SummaryRanges object will be instantiated and called as such:
 * SummaryRanges obj = new SummaryRanges();
 * obj.AddNum(value);
 * int[][] param_2 = obj.GetIntervals();
 */
// @lc code=end

