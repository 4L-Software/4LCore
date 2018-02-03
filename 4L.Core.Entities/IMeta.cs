using System;
using System.Collections.Generic;

namespace _4L.Core.Entities
{
    public interface IMeta
    {
        /// <summary>
        /// Adds a new ITag to this object's meta data
        /// </summary>
        /// <param name="tag">The tag to add to this object's meta data collection</param>
        void Add(ITag tag);

        /// <summary>
        /// Confirms whether this object contains the specified tag
        /// </summary>
        /// <param name="tag">The tag we're looking for</param>
        /// <returns>True if it does, otherwise false</returns>
        bool Contains(ITag tag);
        /// <summary>
        /// Determines how closely this object matches the supplied tags
        /// </summary>
        /// <param name="tags">The supplied collection of ITag objects</param>
        /// <returns>A percentage of how many of the supplied tags have been found in this object</returns>
        double Match(IEnumerable<ITag> tags);
        /// <summary>
        /// Returns a read-only collection of the tags in this object's meta data collection
        /// </summary>
        IEnumerable<ITag> Tags { get; }
    }
}
