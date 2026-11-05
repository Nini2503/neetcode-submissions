public class Solution {

    public string Encode(IList<string> strs) {
       StringBuilder sb=new StringBuilder();
        foreach(string s in strs)
        {
            sb.Append(s.Length).Append('#').Append(s);
        } 
        return sb.ToString();
    }

    public List<string> Decode(string s) {

        List<string> res=new List<string>();
        int i=0;
        while(i<s.Length)
        {
            int j=i;
            while(j<s.Length&&s[j]!='#')
                j++;
            int l=int.Parse(s.Substring(i,j-i));
            res.Add(s.Substring(j+1,l));
            i=j+l+1;
        }
        return res;
   }
}
