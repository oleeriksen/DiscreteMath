using System;
namespace DiscreteMath
{
    public interface ISet
    {
        void Add(int v);
        bool Contains(int v);
        void All(Action<int> f);

    }
}
