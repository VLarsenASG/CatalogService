using Application.Repository;
using Application.Services;
using Domain.Dtos;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using FromBodyAttribute = System.Web.Http.FromBodyAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace CatalogService.Controllers;




public class CatalogController : ApiController
{
    private readonly ICatalogService _movieService;

    public CatalogController(ICatalogService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet("api/catalog")]
    public async Task<IReadOnlyList<VideoIdDto>> GetCatalog()
    {

        var catalog = await _movieService.GetCalatogAsync();
        return catalog;
    }



    [HttpGet("api/movieId")]
    public async Task<VideoIdDto> GetCatalogId(Guid movieId)
    {
        var movie = await _movieService.GetCatalogByIdAsync(movieId);
        return movie;

    }

}
