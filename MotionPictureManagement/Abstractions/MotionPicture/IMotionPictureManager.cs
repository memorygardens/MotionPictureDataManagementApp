using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract = Abstractions.MotionPicture.Models;

namespace Abstractions.MotionPicture
{
    public interface IMotionPictureManager
    {
        /// <summary>
        /// Get a list of all Motion Picture Records 
        /// </summary>
        /// <returns>List of Motion Picture</returns>
        Task<List<Abstract.MotionPicture>> GetAllMotionPictureRecords();

        /// <summary>
        /// Gets Motion Picture By Id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Motion Picture</returns>
        Task<Abstract.MotionPicture> GetMotionPictureById(int id);

        /// <summary>
        /// Add Motion Picture
        /// </summary>
        /// <param name="input">Motion Picture</param>
        /// <returns>Motion Picture</returns>
        Task<Abstract.MotionPicture> AddMotionPicture(Abstract.MotionPicture input);

        /// <summary>
        /// Updates Motion Picture
        /// </summary>
        /// <param name="input">Motion Picture</param>
        /// <returns>bool success or not</returns>
        Task<bool> UpdateMotionPicture(Abstract.MotionPicture input);

        /// <summary>
        /// Delete a Motion Picture by Id 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>bool success or not</returns>
        Task<bool> DeleteMotionPictureById(int id);

    }
}
