class Solution {
    public List<String> generateParenthesis(int n) {
        List<String> res=new ArrayList<>();
        backtrack(n,n,"",res);
        return res;
    }
    void backtrack(int left,int right,String curr, List<String> res)
    {
        if(left==0&&right==0)
        {
            res.add(curr);
            return;
        }
        if(left>0)
            backtrack(left-1,right,curr+"(",res);
        if(right>left)
            backtrack(left,right-1,curr+")",res);
    }
}
