public class Solution {
    public bool IsValid(string st) {
      var s=new Stack<char>(); 
      foreach(char c in st)
      {
        if(c=='('||c=='{'||c=='[')
            s.Push(c);
        else
        {
           
            if(s.Count==0)
                return false;
            else if(c==']'&& s.Peek()=='[')
                s.Pop();
            
            else if(c=='}'&& s.Peek()=='{')
                s.Pop();
            else if(c==')'&& s.Peek()=='(')
                s.Pop();
            else
                return false;
        }
      } 

      return s.Count==0;
    }
}
