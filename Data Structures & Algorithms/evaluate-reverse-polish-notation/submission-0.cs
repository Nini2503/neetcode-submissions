public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack=new Stack<int>();
       foreach(string token in tokens)
       {
            if(int.TryParse(token,out var num))
            {
                stack.Push(num);
            }
            else
            {
                var num2=stack.Pop();
                var num1=stack.Pop();
                int val=0;
                if(token=="+")
                {
                    val=num1+num2;
                }
                else if(token=="-")
                {
                    val=num1-num2;
                }
                else if(token=="*")
                {
                    val=num1*num2;
                }
                else if(token=="/")
                {
                    val=num1/num2;
                }
                stack.Push(val);
            }
       } 
       return stack.Peek();
    }
}
