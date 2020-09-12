/*
 * @lc app=leetcode id=1286 lang=csharp
 *
 * [1286] Iterator for Combination
 */

// @lc code=start
public class CombinationIterator {
    IEnumerator<string> enumerator;
    string characters;
    bool hasNext = true;
    char[] chars;

    public CombinationIterator(string characters, int combinationLength) {
        this.characters = characters;
        chars = new char[combinationLength];
        enumerator = GenerateCombination(0, 0).GetEnumerator();
        enumerator.MoveNext();
    }
    
    private IEnumerable<string> GenerateCombination(int index, int start)
    {
        if (index == chars.Length)
        {
            yield return new string(chars);
            yield break;
        }            
        
        for (int i = start; i < characters.Length; i++)
        {
            chars[index] = characters[i];
            foreach (var s in GenerateCombination(index + 1, i + 1))
                yield return s;
        }
    }

    public string Next() {
        var result = enumerator.Current;
        hasNext = enumerator.MoveNext();
        return result;
    }
    
    public bool HasNext() {
        return hasNext;
    }
}

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * string param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
// @lc code=end

