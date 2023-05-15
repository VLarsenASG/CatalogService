using Application.Repository;
using Application.Services;
using Domain.Dtos;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using static Application.Requests.MovieRequestHandler;
using FromBodyAttribute = System.Web.Http.FromBodyAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace CatalogService.Controllers;




public class CatalogController : ApiController
{
    private readonly IMovieService _movieService;

    public CatalogController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet("api/catalog")]
    public async Task<IReadOnlyList<MovieIdDto>> GetCatalog()
    {

        var catalog = await _movieService.GetCalatogAsync();
        return catalog;
    }



    [HttpGet("api/movieId")]
    public async Task<MovieIdDto> GetMovieId(Guid movieId)
    {
        var movie = await _movieService.GetMovieByIdAsync(movieId);
        return (MovieIdDto)movie;

    }



    /*private readonly IRequestHandler<MovieInput, MovieOutput> requestHandler;


    public CatalogController(IRequestHandler<MovieInput, MovieOutput> requestHandler)
    {
        this.requestHandler = requestHandler;
    }

    [HttpGet]
    [Route("api/catalog")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MovieService))]

    public Task<MovieOutput> Endpoint(CancellationToken cancellationToken)
    {
        return requestHandler.Handle(new MovieInput(), cancellationToken);
    }*/
}
