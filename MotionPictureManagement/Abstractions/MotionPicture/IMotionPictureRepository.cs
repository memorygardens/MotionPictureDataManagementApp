using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract = Abstractions.MotionPicture.Models;

namespace Abstractions.MotionPicture
{
    public interface IMotionPictureRepository
    {
        /// <summary>
        /// Gets all Motion Picture Records
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>A List of All Motion Picture Records</returns>
        Task<List<Abstract.MotionPicture>> GetAllMotionPictureRecords(CancellationToken cancellationToken);
    }
}
