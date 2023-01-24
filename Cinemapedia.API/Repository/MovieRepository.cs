using AutoMapper;
using Cinemapedia.API.Data;
using Cinemapedia.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Cinemapedia.API.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly Context _context;
        private IMapper _mapper;

        public MovieRepository(Context context, IMapper mapper)
        {
            _context= context;
            _mapper= mapper;
        }

        public Context Get_context()
        {
            return _context;
        }

        public async Task<IEnumerable<MovieVO>> GetAll()
        {
            List<Movie> movies = await _context.Movies.ToListAsync();
            return _mapper.Map<IEnumerable<MovieVO>>(movies);
        }

        public async Task<MovieVO> FindById(int id)
        {
            Movie movie = await _context.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<MovieVO>(movie);
        }

        public async Task<MovieVO> Create(MovieVO movieVO)
        {
            Movie movie = _mapper.Map<Movie>(movieVO);
            _context.Add(movie);
            await _context.SaveChangesAsync();
            return _mapper.Map<MovieVO>(movie);
        }
  
        public async Task<MovieVO> Update(MovieVO movieVO, int id)
        {
            Movie movie = _mapper.Map<Movie>(movieVO);
            movie.Id = id;
            _context.Update(movie);
            await _context.SaveChangesAsync();
            return _mapper.Map<MovieVO>(movie);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                Movie movie = await _context.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (movie != null)
                {
                    _context.Remove(movie);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
