using System;
namespace DiscreteMath.Grammar
{
    public class Parser
    {
        /*S ⟶ T + S | T
          T ⟶ F * T | F
          F ⟶ ( S ) | V
          V ⟶  a | b | … | z
         * 
         */ 
        public Parser()
        {
        }

        public IExpression Parse(String s)
        {
            s = RemoveBlanks(s);
            return S(s);
        }

        private IExpression S(String s)
        {
            int idx = LookFor(s, '+');
            if (idx == -1)
                return T(s);
            IExpression left = T(s.Substring(0, idx));
            IExpression right = S(s.Substring(idx + 1));
           
            return new AddExpression(left, right);
        }

        private IExpression T(String s)
        {
            int idx = LookFor(s, '*');
            if (idx == -1)
                return F(s);
            IExpression left = F(s.Substring(0, idx));
            IExpression right = T(s.Substring(idx + 1));

            return new MulExpression(left, right);
        }

        private IExpression F(String s)
        {
            if (s[0] == '(' && s[s.Length - 1] == ')')
                return S(s.Substring(1, s.Length - 2));
            return V(s);
        }

        private IExpression V(String s)
        {
            
            return new VarExpression(s[0]);
        }



        private int LookFor(String s, char key) {
            int level = 0;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == '(')
                    level++;
                if (s[i] == ')')
                    level--;
                if (s[i] == key && level == 0)
                    return i;
            }
            return -1;
        }

        private String RemoveBlanks(String s) {
            String res = "";
            foreach (char ch in s)
                if (ch != ' ')
                    res += ch;
            return res;
        }
    }
}
