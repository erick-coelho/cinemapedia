using Cinemapedia.API.Model;

namespace Cinemapedia.API.Data
{
    public class MovieVO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public float Rating { get; set; }
        public Status Status { get; set; }
    }
}
