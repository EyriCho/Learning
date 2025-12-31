/*
 * @lc app=leetcode id=756 lang=csharp
 *
 * [756] Pyramid Transition Matrix
 */

// @lc code=start
public class Solution {
    public bool PyramidTransition(string bottom, IList<string> allowed) {
        Dictionary<string, IList<char>> translation = new ();
        foreach (string allow in allowed)
        {
            if (!translation.TryGetValue(allow[0..2], out IList<char> list))
            {
                translation[allow[0..2]] = list = new List<char>();
            }
            list.Add(allow[2]);
        }

        bool Dfs(string str, int index, char[] array)
        {
            if (index == str.Length)
            {
                return Helper(new string(array));
            }

            if (!translation.TryGetValue(str[(index - 1)..(index + 1)], out IList<char> list))
            {
                return false;
            }

            foreach (char c in list)
            {
                array[index - 1] = c;
                if (Dfs(str, index + 1, array))
                {
                    return true;
                }
            }

            return false;
        }

        HashSet<string> set = new ();
        bool Helper(string str)
        {
            if (str.Length == 1)
            {
                return true;
            }
            if (set.Contains(str))
            {
                return false;
            }

            char[] array = new char[str.Length - 1];
            
            if (!Dfs(str, 1, array))
            {
                set.Add(str);
                return false;
            }
            
            return true;
        }

        return Helper(bottom);
    }
}
// @lc code=end

