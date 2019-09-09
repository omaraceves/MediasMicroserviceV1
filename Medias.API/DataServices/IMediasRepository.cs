using Medias.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medias.API.DataServices
{
    public interface IMediasRepository
    {
        Task<IEnumerable<Media>> GetMediasAsync();

        Task<Media> GetMediaAsync(Guid id);

        Task<IEnumerable<Media>> GetMediasAsync(IEnumerable<Guid> mediaIds);

        MediaGroup AddMediaGroup(MediaGroup mediaGroupEntityToAdd);

        Media AddMedia(Media mediaEntityToAdd);

        void SaveChanges();
    }
}
