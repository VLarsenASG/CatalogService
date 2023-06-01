using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class CatalogDto
    {
        public Dictionary<Guid, VideoIdDto>? Catalog { get; set; }
   
    }
}
