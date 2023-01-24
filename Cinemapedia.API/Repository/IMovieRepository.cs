using Cinemapedia.API.Data;

namespace Cinemapedia.API.Repository
{
    public interface IMovieRepository
    {
        Task<IEnumerable<MovieVO>> GetAll();
        Task<MovieVO> FindById(int id);
        Task<MovieVO> Create(MovieVO movieVO);
        Task<MovieVO> Update(MovieVO movieVO, int id);
        Task<bool> Delete(int id);
    }
}
