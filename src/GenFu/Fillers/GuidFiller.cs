﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace GenFu.Fillers
{
    class GuidFiller:PropertyFiller<Guid>
    {
        public GuidFiller()
            : base(new[] { "object" }, new[] { "*" }, true)
        { }

        public override object GetValue()
        {
            return Guid.NewGuid();
        }
    }
}