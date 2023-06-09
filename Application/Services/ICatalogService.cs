﻿using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface ICatalogService
    {
        Task<IReadOnlyList<VideoIdDto>> GetCalatogAsync();

        Task<VideoIdDto> GetCatalogByIdAsync(Guid videoId);

    }
}
