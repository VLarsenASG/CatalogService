using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface ICatalogRepository
    {

        Task<IReadOnlyList<VideoIdDto>> GetCatalogAsync();
        Task<VideoIdDto> GetMovieIdAsync(Guid VideoId);

    }
}
