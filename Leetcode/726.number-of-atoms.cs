/*
 * @lc app=leetcode id=726 lang=csharp
 *
 * [726] Number of Atoms
 */

// @lc code=start
public class Solution {
    public string CountOfAtoms(string formula) {
        Dictionary<string, int> Analysis(string f, int count)
        {
            Dictionary<string, int> rst = new ();
            int i = 0;
            while (i < f.Length)
            {
                if (f[i] == '(')
                {
                    int level = 1;
                    int j = ++i;
                    while (j < f.Length)
                    {
                        if (f[j] == '(')
                        {
                            level++;
                        }
                        else if (f[j] == ')')
                        {
                            if (--level == 0)
                            {
                                break;
                            }
                        }
                        j++;
                    }
                    string sub = f[i..j];
                    j++;
                    int number = 0;
                    while (j < f.Length &&
                        f[j] >= '0' && f[j] <= '9')
                    {
                        number = number * 10 + (f[j++] - '0');
                    }
                    if (number == 0)
                    {
                        number = 1;
                    }

                    Dictionary<string, int> subDict = Analysis(sub, number);

                    foreach (KeyValuePair<string, int> kv in subDict)
                    {
                        rst.TryGetValue(kv.Key, out int c);
                        rst[kv.Key] = c + kv.Value;
                    }
                    i = j;
                }
                else
                {
                    int j = i + 1;
                    while (j < f.Length &&
                        f[j] >= 'a')
                    {
                        j++;
                    }

                    string element = f[i..j];
                    int number = 0;
                    while (j < f.Length &&
                        f[j] >= '0' && f[j] <= '9')
                    {
                        number = number * 10 + (f[j++] - '0');
                    }
                    if (number == 0)
                    {
                        number = 1;
                    }

                    rst.TryGetValue(element, out int c);
                    rst[element] = c + number;
                    i = j;
                }

            }

            foreach (string element in rst.Keys)
            {
                rst[element] = rst[element] * count;
            }

            return rst;
        }
        
        Dictionary<string, int> dict = Analysis(formula, 1);

        List<char> list = new();
        foreach (string element in dict.Keys.OrderBy(k => k))
        {

            list.AddRange(element);
            if (dict[element] > 1)
            {
                list.AddRange(dict[element].ToString());
            }
        }
        return new string(list.ToArray());
    }
}
// @lc code=end

