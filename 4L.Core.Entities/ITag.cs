﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4L.Core.Entities
{
    public interface ITag
    {
        ITagName Name { get; set; }
        object Value { get; set; }
    }
}
