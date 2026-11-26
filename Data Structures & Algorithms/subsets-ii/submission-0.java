class Solution {
    public List<List<Integer>> subsetsWithDup(int[] nums) {
          List<List<Integer>> res=new ArrayList<List<Integer>>();
        res.add(new ArrayList<>());
        Arrays.sort(nums);
        backtrack(nums,res,new ArrayList<>(),0);
        return res; 
    }
    void backtrack(int[] nums,List<List<Integer>> res,List<Integer> curr,int index)
    {
        if(index>=nums.length)
            return;
        for(int i=index;i<nums.length;i++)
        {
            List<Integer> currN=new ArrayList<>(curr);
            currN.add(nums[i]);
            if(!res.contains(currN))
                res.add(currN);
            backtrack(nums,res,currN,i+1);
        }
        
    }
}
