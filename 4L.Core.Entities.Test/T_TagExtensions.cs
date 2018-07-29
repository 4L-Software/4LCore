using System;
using Xunit;
using _4L.Core.Entities;

namespace _4L.Core.Entities.Test
{
    public class T_TagExtensions
    {
        [Fact]
        public void _Value_T()
        {
            
            TestTagName tagName = new TestTagName();
            tagName.Name = "Test";

            TestTag tag1 = new TestTag();
            tag1.Name = tagName;
            tag1.Value = 100;
        
            TestTag tag2 = new TestTag();
            tag2.Name = tagName;   
            tag2.Value = "This is a test";

            Assert.Equal(100, tag1.Value<int>());
            Assert.Equal("This is a test", tag2.Value<string>()); 

        }
    }

    public class TestTag : ITag
    {
        public ITagName Name { get; set; }
        public object Value { get; set; }
    }

    public class TestTagName : ITagName
    {
        private Guid _id = Guid.Empty;
        public Guid Id 
        {
            get
            {
                if (_id == Guid.Empty)
                    _id = Guid.NewGuid();

                return _id;
            }
        }
        public string Name { get; set; }
    }
}
