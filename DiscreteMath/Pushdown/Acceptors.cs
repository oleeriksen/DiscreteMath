using System;
using System.Collections.Generic;

namespace DiscreteMath.Pushdown
{
    public class Acceptors
    {
        enum State {
            PHASE1, PHASE2, ACCEPT, REJECT }

        public Acceptors()
        {
        }

        public bool Acceptanbn(Input a) {
            Stack<char> s = new Stack<char>();

            State state = State.PHASE1;

            while (a.More) {
                char c = a.Next;

                switch (state) {
                    case State.PHASE1:
                        if (c == 'a')
                            s.Push(c);

                        else // c == 'b'
                        {
                            if (s.Count == 0) return false;
                            s.Pop();
                            state = State.PHASE2;
                        }    
                        break;
                    case State.PHASE2:
                        if (c == 'b')
                        {
                            if (s.Count > 0)
                                s.Pop();
                            else
                                return false; 

                        }
                        else
                            return false; 
                        break;
                }
            }

            return s.Count == 0;
        }
    }
}
