public class Solution {
    public bool IsPalindrome(string s) {
      s = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
      s=s.ToLower();
        Console.WriteLine(s);
        int left=0;
        int right=s.Length-1;

        while(left<right)
        {
            if( s[left]!=s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
