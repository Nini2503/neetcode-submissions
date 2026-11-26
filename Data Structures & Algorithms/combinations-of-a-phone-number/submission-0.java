class Solution {
    public List<String> letterCombinations(String digits) {
        List<String> res= new ArrayList<String>();
        Map<Character,String> map=new HashMap<>();
        map.put('2',"abc");
        map.put('3',"def");
        map.put('4',"ghi");
        map.put('5',"jkl");
        map.put('6',"mno");
        map.put('7',"pqrs");
        map.put('8',"tuv");
        map.put('9',"wxyz");
        backtrack(digits,res,"",0,map);
        return res;
    }
    void backtrack(String digits,List<String> res,String curr,int i,Map<Character,String> map)
    {
        if(i>=digits.length())
        {
            if(curr.length()>0)
                res.add(curr);
            return;
        }

        String set=map.get(digits.charAt(i));
        for(int j=0;j<set.length();j++)
        {
            String currN=curr+set.charAt(j);
            backtrack(digits,res,currN,i+1,map);
        }
        
    }
}
