﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraigslistClone.Models.Listing_Model
{
    public class RecentListingModel
    {
        public IEnumerable<Listing> recentListings;
        public IEnumerable<Thread> threads;
    }
}
