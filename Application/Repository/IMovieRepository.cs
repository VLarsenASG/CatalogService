﻿using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IMovieRepository
    {

        Task<IReadOnlyList<MovieIdDto>> GetCatalogAsync();
        Task<MovieIdDto> GetMovieIdAsync(Guid MovieId);

    }
}
