using Cinemapedia.API.Model.Base;

namespace Cinemapedia.API.Model
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public float Rating { get; set; }
        public Status Status { get; set; }
    }
}
