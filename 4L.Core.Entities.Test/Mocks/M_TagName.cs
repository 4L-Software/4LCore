using System;

namespace _4L.Core.Entities.Test.Mocks
{
    public class M_TagName : ITagName
    {
        private Guid _id = Guid.Empty;
        private Guid getId()
        {
            if (_id == Guid.Empty)
                _id = Guid.NewGuid();

            return _id;
        }
        public Guid Id { get => getId(); }

        public string Name { get; set; }

        public Guid Owner => throw new NotImplementedException();

        public TagNameVisibility Visibility { get; set; }
    }
}
