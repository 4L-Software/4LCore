using System;
using System.Collections.Generic;

namespace _4L.Core.Entities
{
    /// <summary>
    /// Persistance interface for ITag
    /// </summary>
    public interface ITagPersist
    {
        /// <summary>
        /// Loads a list of ITag objects for the corresponding IMeta object
        /// </summary>
        /// <param name="metaId">The Guid of the IMeta object</param>
        /// <returns>All ITag objects that belong to IMeta</returns>
        IEnumerable<ITag> Fetch(Guid metaId);

        /// <summary>
        /// Saves a list of ITag objects for the corresponding IMeta object
        /// </summary>
        /// <param name="tags">All ITag objects that belong to IMeta</param>
        /// <param name="metaId">The Guid of the IMeta object</param>
        void Push(IEnumerable<ITag> tags, Guid metaId);
    }
}
