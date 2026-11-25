class Solution {
    public List<List<Integer>> combinationSum2(int[] candidates, int target) {
        List<List<Integer>> res=new ArrayList<List<Integer>>();
        Arrays.sort(candidates);
        backtrack(candidates,target,0,res,new ArrayList<>());
        return res;
    }
    void backtrack(int[] candidates,int target,int index, List<List<Integer>> res,List<Integer> curr)
    {
        if(target==0)
        {
            if(curr.size()>0)
                res.add(curr);
            return;
        }
        if(target<0||index>=candidates.length)
            return;
        for(int i=index;i<candidates.length;i++)
        {
            if(i>index && candidates[i]==candidates[i-1])
            continue;

            List<Integer> currN=new ArrayList<>(curr);
            currN.add(candidates[i]);
            backtrack(candidates,target-candidates[i],i+1,res,currN);
        }
        
    }
}
