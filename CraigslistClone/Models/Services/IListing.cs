﻿using CraigslistClone.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraigslistClone.Models.Services
{
    public interface IListing
    {
        Listing GetByID(int id);
        IEnumerable<Listing> GetAll();
        IEnumerable<Listing> GetFilteredPost(string searchQuery);

        Task Add(Listing listing);
        Task Delete(int id);
        Task EditListing(Listing listing);

        Thread GetHostThread(int id);
        IEnumerable<Listing> GetListingsByThread(int id);
        IEnumerable<Listing> GetListingsByUser(string userId);

        IEnumerable<ListingImage> GetListingImages(int id);
    }
}
