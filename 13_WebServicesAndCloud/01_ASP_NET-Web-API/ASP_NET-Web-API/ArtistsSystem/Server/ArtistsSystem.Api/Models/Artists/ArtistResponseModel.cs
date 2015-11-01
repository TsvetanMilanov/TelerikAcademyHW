namespace ArtistsSystem.Api.Models.Artists
{
    using System;
    using System.Collections.Generic;

    public class ArtistResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Country { get; set; }

        public ICollection<string> Albums { get; set; }

        public ICollection<string> Songs { get; set; }
    }
}