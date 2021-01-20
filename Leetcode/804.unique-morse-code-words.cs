/*
 * @lc app=leetcode id=804 lang=csharp
 *
 * [804] Unique Morse Code Words
 */

// @lc code=start
public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        int result = 0;
        MorseTree root = new MorseTree();
        
        foreach (var word in words)
        {
            MorseTree node = root;
            for (int i = 0; i < word.Length; i++)
            {
                var index = word[i] - 'a';
                var morse = map[index];
                
                foreach (var c in morse)
                {
                    if (c == '.')
                    {
                        if (node.left == null)
                            node.left = new MorseTree();
                        node = node.left;
                    }
                    else
                    {
                        if (node.right == null)
                            node.right = new MorseTree();
                        node = node.right;                        
                    }
                }
            }
            
            if (!node.isWord)
            {
                node.isWord = true;
                result++;
            }
        }
        
        return result;
    }
    
    readonly string[] map = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
    
    class MorseTree
    {
        internal bool isWord;
        internal MorseTree left;
        internal MorseTree right;
    }
}
// @lc code=end

