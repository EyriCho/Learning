/*
 * @lc app=leetcode id=535 lang=csharp
 *
 * [535] Encode and Decode TinyURL
 */

// @lc code=start
public class Codec {
    string prefix = "http://t.com/";
    int count = 0;
    List<string> map = new List<string>();
    
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        map.Add(longUrl);
        return prefix + count++;       
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        int index = int.Parse(shortUrl.Substring(shortUrl.LastIndexOf('/') + 1));
        return map[index];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));
// @lc code=end

