public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map=new Dictionary<int,int>();
        foreach(int num in nums)
        {
            if(map.ContainsKey(num))
                map[num]++;
            else
                map[num]=1;
        }

        var freq=new List<int>[nums.Length];
        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        foreach(var entry in map)
        {
            freq[entry.Value-1].Add(entry.Key);
        }
        
        int count=0;
        int[] res=new int[k];
        for(int i=nums.Length-1;i>=0;i--)
        {
            foreach(int num in freq[i])
            {
                res[count++]=num;
                if(count==k)
                    return res;
            }
        }
        return res;
    }
}
