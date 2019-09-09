using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medias.API.Context;
using Medias.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Medias.API.DataServices
{
    public class MediasRepository : IMediasRepository
    {
        private MediasContext _context;

        public MediasRepository(MediasContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public MediaGroup AddMediaGroup(MediaGroup mediaGroupEntityToAdd)
        {
            _context.MediaGroups.Add(mediaGroupEntityToAdd);

            return mediaGroupEntityToAdd;
        }

        public Media AddMedia(Media mediaEntityToAdd)
        {
            _context.Medias.Add(mediaEntityToAdd);

            return mediaEntityToAdd;
        }

        public async Task<Media> GetMediaAsync(Guid id)
        {
            return await _context.Medias.Include(x => x.MediaGroup)
                .Where(x => x.Id == id).FirstOrDefaultAsync() ?? null;
        }

        public async Task<IEnumerable<Media>> GetMediasAsync()
        {
            return await _context.Medias.Include(x => x.MediaGroup).ToListAsync() ?? null;
        }

        public async Task<IEnumerable<Media>> GetMediasAsync(IEnumerable<Guid> mediaIds)
        {
            return await _context.Medias.Include(x => x.MediaGroup).Where(m => mediaIds.Contains(m.Id)).ToListAsync() ?? null;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
