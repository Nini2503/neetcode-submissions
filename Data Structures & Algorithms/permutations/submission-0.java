class Solution {
    public List<List<Integer>> permute(int[] nums) {
        List<List<Integer>> res=new ArrayList<List<Integer>>();
        backtrack(nums,new ArrayList<Integer>(),res);
        return res;
    }
    void backtrack(int[] nums, List<Integer> curr,List<List<Integer>> res)
    {
        if(curr.size()==nums.length)
        {
            res.add(curr);
            return;
        }
        for(int num:nums)
        {
            if(!curr.contains(num))
            {
                List<Integer> nCurr=new ArrayList<>(curr);
                nCurr.add(num);
                backtrack(nums,nCurr, res);
            }
        }
    }
}
