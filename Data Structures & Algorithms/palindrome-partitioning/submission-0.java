class Solution {
    public List<List<String>> partition(String s) {
        List<List<String>> res=new ArrayList<List<String>>();
        backtrack(s,0,res,new ArrayList<>());
        return res;
    }
    void backtrack(String s,int i,List<List<String>> res,List<String> curr)
    {
        if(i==s.length())
        {
            res.add(curr);
            return;
        }
        for(int j=i;j<s.length();j++)
        {
            if(isPali(s,i,j))
            {
                List<String> currN=new ArrayList<String>(curr);
                currN.add(s.substring(i,j+1));
                backtrack(s,j+1,res,currN);
            }
        }
    }
    boolean isPali(String s,int l,int h)
    {
        while(l<h)
        {
            if(s.charAt(l)!=s.charAt(h))
                return false;
            l++;
            h--;
        }
        return true;
    }
}
