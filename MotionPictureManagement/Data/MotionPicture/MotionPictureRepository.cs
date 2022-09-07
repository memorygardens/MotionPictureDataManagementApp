using Abstractions.MotionPicture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract = Abstractions.MotionPicture.Models;

namespace Data.MotionPicture
{
    public class MotionPictureRepository : IMotionPictureRepository 
    {
        public async Task<List<Abstract.MotionPicture>> GetAllMotionPictureRecords(CancellationToken cancellationToken)
        {

        }
    }
}
