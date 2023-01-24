using AutoMapper;
using Cinemapedia.API.Data;
using Cinemapedia.API.Model;

namespace GenshinData.CharacterAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<MovieVO, Movie>();
                config.CreateMap<Movie, MovieVO>();
            });
            return mappingConfig;
        }
    }
}
