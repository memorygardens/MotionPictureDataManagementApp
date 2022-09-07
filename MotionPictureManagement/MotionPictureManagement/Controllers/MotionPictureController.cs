using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MotionPictureManagement.MotionPicture.Dtos;
using System.Net;
using Abstractions.MotionPicture;

namespace MotionPictureManagement.Controllers
{
    [ApiController]
    [Route("MotionPicture")]
    public class MotionPictureController : ControllerBase
    {
        #region Globals and Constants

        private IMotionPictureManager _manager;
        private ILogger<MotionPictureController> _logger;
        private IMapper _mapper;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of MotionPictureController
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="mapper">Mapper</param>
        public MotionPictureController(ILogger<MotionPictureController> logger, IMotionPictureManager manager, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        #endregion

        [HttpGet("MotionPicture")]
        [ProducesResponseType(typeof(MotionPictureDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllMotionPictures(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Displaying all Motion Picture Records");

            var results = _manager.GetAllMotionPictureRecords(cancellationToken);
            var dto = _mapper.Map<MotionPictureDto>(results);

            return Ok(dto);
        }




        //view a listing table of all motion pictures records saved to the database 


        //create a new motion picture record

        //copy existing motion picture record

        //edit existing motion picture record

        // delete existing motion pictures record
    }
}
