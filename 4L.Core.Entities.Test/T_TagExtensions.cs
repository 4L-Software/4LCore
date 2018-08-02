using System;
using Xunit;
using _4L.Core.Entities;
using _4L.Core.Entities.Test.Mocks;

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

    

    
}
