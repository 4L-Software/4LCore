using System;
using System.Collections.Generic;

namespace _4L.Core.Entities
{
    public interface IMeta
    {
        void Add(ITag tag);
        bool Contains(ITag tag);
        double Match(IEnumerable<ITag> tags);
        IEnumerable<ITag> Tags { get; }
    }
}
