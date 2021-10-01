/*
 * @lc app=leetcode id=929 lang=csharp
 *
 * [929] Unique Email Addresses
 */

// @lc code=start
public class Solution {
    public int NumUniqueEmails(string[] emails) {
        var set = new HashSet<string>();
        
        foreach (var email in emails)
        {
            var array = email.ToCharArray();
            
            int i = 0, index = 0;
            char[] local = null;
            
            while (i < email.Length && email[i] != '@')
            {
                if (email[i] == '.')
                {
                    
                }
                else if (email[i] == '+')
                {
                    local = array[0..index];
                }
                else if (local == null)
                {
                    if (i > index)
                        array[index] = array[i];
                    index++;
                }
                    
                i++;
            }
            
            if (local == null)
                local = array[0..index];
            
            var address = $"{new string(local)}{new string(array[i..])}";
            if (!set.Contains(address))
                set.Add(address);
        }
        return set.Count;
    }
}
// @lc code=end

