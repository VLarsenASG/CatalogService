using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class MovieRepository : IMovieRepository
    {

        private readonly Dictionary<Guid, MovieIdDto> movieCollection = new Dictionary<Guid, MovieIdDto>()
            {
            //movieIdDto har indsat 5 for at lave 2 guid id'er en til guid og en til movieId
                { Guid.Parse("b4315028-60cb-4571-b81c-ecec008d908c") , new MovieIdDto(Guid.Parse("b5315028-60cb-4571-b81c-ecec008d908c")) }
            };

        public Task<IReadOnlyList<MovieIdDto>> GetCatalogAsync()
        {         
            return Task.FromResult<IReadOnlyList<MovieIdDto>>(movieCollection.Values.ToList());          
        }

        public Task<MovieIdDto> GetMovieIdAsync(Guid MovieId)
        {
            
            movieCollection.TryGetValue(MovieId, out var id);
            return Task.FromResult(id);   
        }
    }
}
