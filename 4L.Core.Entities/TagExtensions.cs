
namespace _4L.Core.Entities
{
    public static class TagExtensions
    {
        public static T Value<T>(this ITag tag)
        {
            return (T)tag.Value;
        }
    }
}