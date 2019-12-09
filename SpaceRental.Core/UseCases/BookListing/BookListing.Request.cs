using System;
using SpaceRental.Core.Entities;

namespace SpaceRental.Core.UseCases
{
    public class BookListingRequest
    {
        public Guid StudioListing { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public Payment Payment { get; set; }
    }
}