using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Data.DAO.MotionPicture
{
    public class MotionPictureDAO
    {
        private MotionPictureContext motionPictureContext { get; }

        public MotionPictureDAO(MotionPictureContext motionPictureContext)
        {
            this.motionPictureContext = motionPictureContext;
        }



        #region Const



        #endregion
    }
}
