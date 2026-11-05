class Solution {
    public String foreignDictionary(String[] words) {
       Map<Character,List<Character>> adjList=new HashMap<>();
        Map<Character,Integer> count=new HashMap<>();
        
        for(String word:words)
        {
           for(char c:word.toCharArray())
           {
               count.put(c,0);
               adjList.put(c,new ArrayList<>());
           }
        }
        
        for(int i=0;i<words.length-1;i++)
        {
            String word1=words[i];
            String word2=words[i+1];
            if(word1.length()>word2.length()&&word1.startsWith(word2))
                return "";
            if(!word1.equals(word2))
            {
                int n=Math.min(word1.length(),word2.length());
                for(int j=0;j<n;j++)
                {
                    if(word1.charAt(j)!=word2.charAt(j))
                    {
                        char wc1=word1.charAt(j);
                        char wc2=word2.charAt(j);
                        adjList.get(wc1).add(wc2);
                        count.put(wc2,count.getOrDefault(wc2,0)+1);
                        break;
                        
                    }
                }
            }
        }
        
        Queue<Character> q=new LinkedList<>();
        for(char c:count.keySet())
        {
            if(count.get(c)==0)
                q.offer(c);
        }
        
        StringBuilder res=new StringBuilder();
        while(!q.isEmpty())
        {
            Character c=q.poll();
            res.append(c);
            List<Character> neighbors=adjList.get(c);
            for(Character neighbor:neighbors)
            {
                int n=count.get(neighbor)-1;
                if(n==0)
                    q.offer(neighbor);
                count.put(neighbor,n);
                
            }
            
        }
        if(res.length()<count.size())
            return "";
        return res.toString();
    }
}
