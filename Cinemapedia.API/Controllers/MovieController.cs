using Cinemapedia.API.Data;
using Cinemapedia.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cinemapedia.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _repository;
        public MovieController(IMovieRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieVO>>> Get()
        {
            var movies = await _repository.GetAll();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieVO>> Get(int id)
        {
            var Movie = await _repository.FindById(id);
            if(Movie == null) return NotFound();
            return Ok(Movie);
        }

        [HttpPost]
        public async Task<ActionResult<MovieVO>> Post([FromBody] MovieVO vo)
        {
            try
            {
                await _repository.Create(vo);
                return Ok(vo);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MovieVO>> Put([FromBody] MovieVO vo, int id)
        {
            try
            {
                await _repository.Update(vo, id);
                return Ok(vo);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await _repository.Delete(id);
            return Ok(result);
        }
    }


}
