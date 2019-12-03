using System;

namespace SpaceRental.Core.Entities
{
    public class User
    {
        public string Email { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public Guid UserId { get; set; }
        public string Password { get; set; }
    }
}