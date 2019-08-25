using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Medias.API.DataServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medias.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediasController : ControllerBase
    {
        private IMediasRepository _repo;
        private IMapper _mapper;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="repository"></param>
        public MediasController(IMediasRepository repository, IMapper mapper)
        {
            _repo = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Gets all medias
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Entities.Media>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMedias()
        {
            var mediaEntities = await _repo.GetMediasAsync();
            var result = _mapper.Map<IEnumerable<Model.MediaModel>>(mediaEntities);

            return Ok(result);
        }


        /// <summary>
        /// Gets a media
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}", Name = "GetMedia")]
        [ProducesResponseType(typeof(Model.MediaModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMedia([FromRoute] string id)
        {
            var mediaEntity = await _repo.GetMediaAsync(Guid.Parse(id));

            if (mediaEntity == null)
            {
                return NotFound();
            }

            var result = _mapper.Map<Model.MediaModel>(mediaEntity);

            return Ok(result);
        }
    }
}