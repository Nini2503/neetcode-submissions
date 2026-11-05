public class Solution {
    public bool CheckInclusion(string s1, string s2) {
      if(s1.Length>s2.Length)
        return false;
        int windowSize=s1.Length;
        int[] s1Count=new int[26];
        int[] s2Count=new int[26];
        for(int i=0;i<s1.Length;i++)
        {
            s1Count[s1[i]-'a']++;
            s2Count[s2[i]-'a']++;
        }
        int front=0;
        for(int rear=windowSize;rear<s2.Length;rear++)
        {
            
            if(s1Count.SequenceEqual(s2Count))
                return true;
            
            s2Count[s2[front]-'a']--;
            front++;

            s2Count[s2[rear]-'a']++;
        }
        return s1Count.SequenceEqual(s2Count);
    }
}
