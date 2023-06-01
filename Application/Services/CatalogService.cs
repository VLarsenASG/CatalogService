using Application.Repository;
using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CatalogService : ICatalogService
    {

        private readonly ICatalogRepository _catalogRepository;

        public CatalogService(ICatalogRepository movieRepository)
        {
            this._catalogRepository = movieRepository;
        }

        public async Task<IReadOnlyList<VideoIdDto>> GetCalatogAsync()
        {
            var catalog = await _catalogRepository.GetCatalogAsync();
            return catalog;

        }

        public async Task<VideoIdDto> GetCatalogByIdAsync(Guid movieId)
        {
            var movieIds = await _catalogRepository.GetMovieIdAsync(movieId);
            return movieIds;
        }
    }

}
