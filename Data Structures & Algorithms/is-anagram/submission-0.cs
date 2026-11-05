public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
            return false;

        int[] count1=new int[26];
        foreach(char c in s)
            count1[c-'a']++;
        
        int[] count2=new int[26];
        foreach(char c in t)
            count2[c-'a']++;
        
        string s_processed=string.Join('#',count1);
        string t_processed=string.Join('#',count2);
        return (s_processed==t_processed);
    }
}
