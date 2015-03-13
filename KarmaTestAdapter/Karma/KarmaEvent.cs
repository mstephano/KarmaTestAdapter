﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarmaTestAdapter.Karma
{
    public class KarmaEvent
    {
        public string Event { get; set; }
        public IEnumerable<Guid> Tests { get; set; }

        public override string ToString()
        {
            return Event;
        }
    }
}