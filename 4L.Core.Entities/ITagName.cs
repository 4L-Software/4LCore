using System;

namespace _4L.Core.Entities
{
    public interface ITagName
    {
        Guid Id {get;}
        string Name { get; set; }
        Guid Owner { get; }
        TagNameVisibility Visibility { get; set; }
    }
}
