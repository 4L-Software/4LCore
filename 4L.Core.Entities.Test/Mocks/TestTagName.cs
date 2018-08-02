﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4L.Core.Entities.Test.Mocks
{
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
