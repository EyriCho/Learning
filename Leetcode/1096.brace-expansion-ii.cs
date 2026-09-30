/*
 * @lc app=leetcode id=1096 lang=csharp
 *
 * [1096] Brace Expansion II
 */

// @lc code=start
public class Solution {
    public IList<string> BraceExpansionII(string expression) {
        List<char> op = new ();
        List<SortedSet<string>> stack = new ();
        Comparer<string> comparer = Comparer<string>.Create((a, b) => string.CompareOrdinal(a, b));

        void Operate()
        {
            int l = stack.Count - 2,
                r = stack.Count - 1;
            
            if (op[^1] == '+')
            {
                stack[^2].UnionWith(stack[^1]);
            }
            else
            {
                SortedSet<string> tmp = new (comparer);
                foreach (string a in stack[^2])
                {
                    foreach (string b in stack[^1])
                    {
                        tmp.Add($"{a}{b}");
                    }
                }
                stack[^2] = tmp;
            }
            op.RemoveAt(op.Count - 1);
            stack.RemoveAt(stack.Count - 1);
        }

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == ',')
            {
                while(op.Count > 0 && op[^1] == '*')
                {
                    Operate();
                }
                op.Add('+');
            }
            else if (expression[i] == '{')
            {
                if (i > 0 && 
                    (expression[i - 1] == '}' || char.IsLetter(expression[i - 1])))
                {
                    op.Add('*');
                }
                op.Add('{');
            }
            else if (expression[i] == '}')
            {
                while (op.Count > 0 && op[^1] != '{')
                {
                    Operate();
                }
                op.RemoveAt(op.Count - 1);
            }
            else
            {
                if (i > 0 &&
                    (expression[i - 1] == '}' || char.IsLetter(expression[i - 1])))
                {
                    op.Add('*');
                }
                SortedSet<string> set = new (comparer);
                set.Add(expression[i].ToString());
                stack.Add(set);
            }
        }

        while (op.Count > 0)
        {
            Operate();
        }

        return new List<string>(stack[^1]);
    }
}
// @lc code=end

