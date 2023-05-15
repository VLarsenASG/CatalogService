using Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Requests;

public class MovieRequestHandler
{
    /*private readonly IMovieService movieService;

    public MovieRequestHandler(IMovieService movieService)
    {
        this.movieService = movieService;
    }

    public async Task<MovieOutput> Handle(MovieInput request, CancellationToken cancellationToken)
    {
        var movies = await movieService.GetCalatogAsync();

        var outputMovie = movies
            .Select(movie => new MovieOutputCatalog(movie.MovieId))
            .ToList();
        return new MovieOutput(outputMovie);
    }


    public record MovieInput : IRequest<MovieOutput>;
    public record MovieOutput(IEnumerable<MovieOutputCatalog> Catalog);
    public record MovieOutputCatalog(Guid MovieId);

    */


}
