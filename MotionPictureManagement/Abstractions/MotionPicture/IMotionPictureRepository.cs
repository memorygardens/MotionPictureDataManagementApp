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
        Task<List<Abstract.MotionPicture>> GetAllMotionPictureRecords();

        /// <summary>
        /// Get Motion Picture By Id 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>MotionPicture</returns>
        Task<Abstract.MotionPicture> GetMotionPictureById(int id);

        /// <summary>
        /// Add Motion Picture 
        /// </summary>
        /// <param name="input">Input Motion Picture</param>
        /// <returns>New Motion Picture</returns>
        Task<Abstract.MotionPicture> AddMotionPicture(Abstract.MotionPicture input);

        /// <summary>
        /// Updates Motion Picture 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<bool> UpdateMotionPicture(Abstract.MotionPicture input);

        /// <summary>
        /// Deletes Motion Picture
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>True or False whether the Motion Picture can be Deleted</returns>
        Task<bool> DeleteMotionPictureById(int id);
    }
}
