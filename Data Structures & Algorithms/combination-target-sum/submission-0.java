class Solution {
    public List<List<Integer>> combinationSum(int[] nums, int target) {
        List<List<Integer>> res=new ArrayList<>();
        backtrack(nums,new ArrayList<>(),res,target,0);
        return res;
    }
    void backtrack(int[] nums,List<Integer> curr,List<List<Integer>> res,int target,int index)
    {
        if(target==0 && curr.size()!=0)
        {
            if(!res.contains(curr))
                res.add(curr);
            return;
        }
        if(target<0||index>=nums.length)
            return;
        List<Integer> currN=new ArrayList<>(curr);
        currN.add(nums[index]);
        backtrack(nums,currN,res,target-nums[index],index+1);
        backtrack(nums,currN,res,target-nums[index],index);
        currN=new ArrayList<>(curr);
        backtrack(nums,curr,res,target,index+1);
    }
}
