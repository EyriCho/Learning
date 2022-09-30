/*
 * @lc app=leetcode id=990 lang=csharp
 *
 * [990] Satisfiability of Equality Equations
 */

// @lc code=start
public class Solution {
    public bool EquationsPossible(string[] equations) {
        var group = new int[26];
        for (int i = 0; i < 26; i++)
        {
            group[i] = i;
        }
        
        int GetGroup(int letter)
        {
            while (group[letter] != letter)
            {
                letter = group[letter];
            }
            return letter;
        }
        
        foreach (var equation in equations)
        {
            if (equation[1] == '=')
            {
                group[GetGroup(equation[0] - 'a')] = GetGroup(equation[3] - 'a');
            }
            
        }
        
        for (int i = 0; i < 26; i++)
        {
            Console.WriteLine($"{(char)('a' + i)} - {group[i]}");
        }
        foreach (var equation in equations)
        {
            if (equation[1] == '!')
            {
                if (GetGroup(equation[0] - 'a') ==
                    GetGroup(equation[3] - 'a'))
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}
// @lc code=end

