/*
 * @lc app=leetcode id=816 lang=csharp
 *
 * [816] Ambiguous Coordinates
 */

// @lc code=start
public class Solution {
    public IList<string> AmbiguousCoordinates(string s) {
        IEnumerable<string> GetNumbers(string str)
        {
            var hasLeadingZero = str[0] == '0';
            var hasTrailingZero = str[str.Length - 1] == '0';
            
            if (hasLeadingZero && hasTrailingZero)
            {
                if (str.Length == 1)
                    yield return str;
            }
            else if (hasLeadingZero && !hasTrailingZero)
                yield return $"0.{str[1..]}";
            else if (!hasLeadingZero && hasTrailingZero)
                yield return str;
            else
            {
                var array = new char[str.Length + 1];
                for (int i = 0; i < str.Length; i++)
                    array[i] = str[i];
                
                for (int i = str.Length; i > 1; i--)
                {
                    array[i] = array[i - 1];
                    array[i - 1] = '.';
                    yield return new string(array);
                }
                yield return str;
            }
        }
        
        var result = new List<string>();
        for (int i = 2; i < s.Length - 1; i++)
        {
            string first = s[1..i],
                second = s[i..(s.Length - 1)];
            
            foreach (var x in GetNumbers(first))
                foreach (var y in GetNumbers(second))
                    result.Add($"({x}, {y})");
        }
        
        return result;
    }
}
// @lc code=end

