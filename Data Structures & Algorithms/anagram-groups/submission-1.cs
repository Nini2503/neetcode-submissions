public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map=new();
        foreach(string s in strs)
        {
            string key=GenerateKey(s);
            if(!map.ContainsKey(key))
                map[key]=new List<string>();
            map[key].Add(s);
        }
        return new List<List<string>> (map.Values);
    }
    string GenerateKey(string s)
    {
        int[] arr=new int[26];
        foreach(char c in s)
            arr[c-'a']++;
        return string.Join('#',arr);
    }
}
