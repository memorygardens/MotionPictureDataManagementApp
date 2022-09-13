using Abstractions.MotionPicture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions.MotionPicture.Models;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Abstract = Abstractions.MotionPicture.Models;

namespace BusinessLogic.MotionPicture.Managers
{
    public class MotionPictureDefaultManager : IMotionPictureManager 
    {
        readonly IMotionPictureRepository _motionPictureRepository;
        readonly ILogger<MotionPictureDefaultManager> _logger;
        readonly IMapper _mapper;

        public MotionPictureDefaultManager(IMotionPictureRepository motionPictureRepository, ILogger<MotionPictureDefaultManager> logger, IMapper mapper)
        {
            _motionPictureRepository = motionPictureRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<List<Abstract.MotionPicture>> GetAllMotionPictureRecords()
        {
            return await _motionPictureRepository.GetAllMotionPictureRecords();
        }

        public async Task<Abstract.MotionPicture> GetMotionPictureById(int id)
        {
            return await _motionPictureRepository.GetMotionPictureById(id);
        }

        public async Task<Abstract.MotionPicture> AddMotionPicture(Abstract.MotionPicture input)
        {
            return await _motionPictureRepository.AddMotionPicture(input);
        }

        public async Task<bool> UpdateMotionPicture(Abstract.MotionPicture input)
        {
            return await _motionPictureRepository.UpdateMotionPicture(input);
        }

        public async Task<bool> DeleteMotionPictureById(int id)
        {
            return await _motionPictureRepository.DeleteMotionPictureById(id);
        }


    }
}
