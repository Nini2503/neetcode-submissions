public class Solution {
    public string MinWindow(string s, string t) {
        if((t.Length>s.Length)||(t==""))
            return "";
        var tdict=new Dictionary<char,int>();
        foreach(char c in t)
        {
            if(tdict.ContainsKey(c))
                tdict[c]++;
            else
                tdict[c]=1;
        }

        var window=new Dictionary<char,int>();
        int res=int.MaxValue;
        int front=0;
        int start=-1,end=-1;
        int have=0,need=tdict.Count;
        for(int rear=0;rear<s.Length;rear++)
        {
            char c=s[rear];
            if(window.ContainsKey(c))
                window[c]++;
            else
                window[c]=1;

            if(tdict.ContainsKey(c)&&tdict[c]==window[c])
                have++;

            while(have==need)
            {
                if(res>rear-front+1)
                {
                    start=front;
                    end=rear;
                    res=rear-front+1;
                }
                
                if(tdict.ContainsKey(s[front]) && tdict[s[front]]==             window[s[front]])
                    have--;

                window[s[front]]--;
                front++;
            }

        }
        return res==int.MaxValue? "":s.Substring(start,res);
    }
}
