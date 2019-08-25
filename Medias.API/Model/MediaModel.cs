using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medias.API.Model
{
    public class MediaModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MediaGroup { get; set; }
    }
}
