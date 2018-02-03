using System;
using System.Collections.Generic;
using System.Text;

namespace _4L.Core.Entities
{
    public interface ITagName
    {
        Guid Id {get;}
        string Name { get; set; }
    }
}
