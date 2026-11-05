class Solution {
    public String longestPalindrome(String s) {
        HashMap<Character,Integer> hmap=new HashMap<>();
        int n=s.length();
        if(n<=1)
        return s;
        int maxLength=0;
        String res="";
        for(int i=0;i<n;i++)
        {
            for(int j=i;j<n;j++)
            {
                if(s.charAt(i)==s.charAt(j))
                {
                    String word=s.substring(i,j+1);
                    if(word.length()>maxLength&&isPaliandrome(word))
                    {
                        res=word;
                        maxLength=word.length();
                    }
                }
            }
        }
        return res;
    }
    boolean isPaliandrome(String word)
    {
        int i=0,j=word.length()-1;
        while(i<=j)
        {
            if(word.charAt(i)!=word.charAt(j))
            return false;
            i++;
            j--;
        }
        return true;
    }
}
