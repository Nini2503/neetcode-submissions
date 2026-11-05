public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var indexMap=new Dictionary<int,int>();
        int front=0;
        int maxLength=0;
        for (int rear=0;rear<s.Length;rear++)
        {
            if(indexMap.ContainsKey(s[rear]))
            {
                front=Math.Max(indexMap[s[rear]]+1,front);
               
            }
            //Console.WriteLine(front+" "+rear);
            indexMap[s[rear]]=rear;
            maxLength=Math.Max(maxLength,rear-front+1);
            
        }

        return maxLength;
    }
}
