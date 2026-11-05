public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict=new Dictionary<int,int>();
        int front=0;
        int maxFreq=0;
        int res=0;
        for(int rear=0;rear<s.Length;rear++)
        {
            if(dict.ContainsKey(s[rear]))
                dict[s[rear]]++;
            else
                dict[s[rear]]=1;

            maxFreq=Math.Max(maxFreq,dict[s[rear]]);
            int windowLength=(rear-front+1);
            if(windowLength-maxFreq<=k)
                res=Math.Max(res,windowLength);
            else
            {
                dict[s[front]]--;
                front++;
            }
        }
        return res;
    }
}
