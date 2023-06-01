using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class CatalogRepository : ICatalogRepository
    {

        private readonly Dictionary<Guid, VideoIdDto> movieCollection = new Dictionary<Guid, VideoIdDto>()
            {
            
            //movieIdDto har indsat 5 for at lave 2 guid id'er en til guid og en til movieId
                { Guid.Parse("b4315028-60cb-4571-b81c-ecec008d908c") , new VideoIdDto(Guid.Parse("b5315028-60cb-4571-b81c-ecec008d908c"), "SuperMario.jpg") }
            };

        public Task<IReadOnlyList<VideoIdDto>> GetCatalogAsync()
        {         
            return Task.FromResult<IReadOnlyList<VideoIdDto>>(movieCollection.Values.ToList());          
        }

        public Task<VideoIdDto> GetMovieIdAsync(Guid MovieId)
        {
            
            movieCollection.TryGetValue(MovieId, out var id);
            return Task.FromResult(id);   
        }
    }
}
