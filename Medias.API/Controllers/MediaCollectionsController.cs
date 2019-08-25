using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Medias.API.DataServices;
using Medias.API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medias.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaCollectionsController : ControllerBase
    {
        private IMediasRepository _repo;
        private IMapper _mapper;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="repository"></param>
        public MediaCollectionsController(IMediasRepository repository, IMapper mapper)
        {
            _repo = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// Get medias collection
        /// </summary>
        /// <param name="mediaIds">Returns a collection of medias for a given id.</param>
        /// <returns></returns>
        [HttpGet("({mediaIds})", Name = "GetMediasCollection")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Model.MediaModel>))]
        public async Task<IActionResult> GetMediasCollection([FromRoute][ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> mediaIds)
        {
            var mediaEntities = await _repo.GetMediasAsync(mediaIds);

            if (mediaIds.Count() != mediaEntities.Count())
            {
                return NotFound();
            }

            var result = _mapper.Map<IEnumerable<Model.MediaModel>>(mediaEntities);

            return Ok(result);
        }
    }
}