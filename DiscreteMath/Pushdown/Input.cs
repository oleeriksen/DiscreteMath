using System;
namespace DiscreteMath.Pushdown
{
    public class Input
    {
        string mContent;
        int i = 0;
        public Input(string content)
        {
            mContent = content;
        }

        public bool More { get { return i < mContent.Length;  } }

        public char Next { get { return mContent[i++]; } }

        public char Peek { get { return mContent[i];  } }


    }
}
