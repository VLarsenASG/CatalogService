using Application.Repository;
using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MovieService : IMovieService
    {

        private readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public async Task<IReadOnlyList<MovieIdDto>> GetCalatogAsync()
        {
            var catalog = await movieRepository.GetCatalogAsync();
            return catalog;

        }

        public async Task<MovieIdDto> GetMovieByIdAsync(Guid movieId)
        {
            var movieIds = await movieRepository.GetMovieIdAsync(movieId);
            return movieIds;
        }
    }

}
