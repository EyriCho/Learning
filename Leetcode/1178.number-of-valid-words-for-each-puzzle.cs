/*
 * @lc app=leetcode id=1178 lang=csharp
 *
 * [1178] Number of Valid Words for Each Puzzle
 */

// @lc code=start
public class Solution {
    public IList<int> FindNumOfValidWords(string[] words, string[] puzzles) {
        var result = new List<int>(puzzles.Length);
        
        var dict = new Dictionary<int, int>();
        int stringToInt(string s)
        {
            var present = 0;
            foreach (var c in s)
                present |= 1 << (c - 'a') ;
            return present;
        }
        for (int i = 0; i < words.Length; i++)
        {
            var p = stringToInt(words[i]);
            if (dict.ContainsKey(p))
                dict[p]++;
            else
                dict[p] = 1;
        }
        
        for (int i = 0; i < puzzles.Length; i++)
        {
            var puzzle = stringToInt(puzzles[i]);
            var first = 1 << (puzzles[i][0] - 'a');
            
            var count = 0;
            for (int s = puzzle + 1; s != 0;)
            {
                s = puzzle & (s - 1);
                
                if ((s & first) == first)
                    count += dict.GetValueOrDefault(s, 0);
            }
            result.Add(count);
        }
        return result;
    }
}
// @lc code=end

