using System;
using System.Collections.Generic;
using System.Text;

namespace _4L.Core.Entities.Test.Mocks
{
    public class TestTag : ITag
    {
        public ITagName Name { get; set; }
        public object Value { get; set; }
    }
}
