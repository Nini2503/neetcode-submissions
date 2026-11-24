class Solution {
    public List<List<Integer>> subsets(int[] nums) {
        List<List<Integer>> res=new ArrayList<List<Integer>>();
        res.add(new ArrayList<Integer>());
        backtrack(nums, new ArrayList<Integer>(),res,0);
        return res;
    }
    void backtrack(int[] nums, List<Integer> curr,List<List<Integer>> res,int index)
    {
        for(int i=index;i<nums.length;i++)
        {
            if(!curr.contains(nums[i]))
            {
                List<Integer> currN=new ArrayList<>(curr);
                currN.add(nums[i]);
            
            if(!res.contains(currN))
            {
                res.add(currN);
            }
            backtrack(nums,currN,res,i+1);
            }
        }
    }
}
