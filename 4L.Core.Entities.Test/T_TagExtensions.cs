using Xunit;
using _4L.Core.Entities.Test.Mocks;

namespace _4L.Core.Entities.Test
{
    public class T_TagExtensions
    {
        /// <summary>
        /// Verifies that the Value<T>() extension method TagExtensions works as expected
        /// </summary>
        [Fact]
        public void _Value_T()
        {
            //create a mocked tag name
            var tagName = new M_TagName
            {
                Name = "Test"
            };

            //create a first mocked tag that has an integer for the value
            M_Tag tag1 = new M_Tag();
            tag1.Name = tagName;
            tag1.Value = 100;
        
            //create a second mocked tag that has a string for the value
            M_Tag tag2 = new M_Tag();
            tag2.Name = tagName;   
            tag2.Value = "This is a test";

            //now assert that the values come back correctly when we use Value<T>
            Assert.Equal(100, tag1.Value<int>());
            Assert.Equal("This is a test", tag2.Value<string>());
            //finally assert that the tag name is identical - not technically part of this test
            Assert.Equal(tag1.Name, tag2.Name);

        }
    }    
}
