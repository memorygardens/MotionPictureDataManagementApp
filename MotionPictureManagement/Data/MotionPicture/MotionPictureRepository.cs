using Abstractions.MotionPicture;
using Data.DAO.MotionPicture;
using Microsoft.Data.SqlClient;
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

        MotionPictureContext context;

        public MotionPictureRepository(MotionPictureContext context)
        {
            this.context = context;
        }

        public async Task<List<Abstract.MotionPicture>> GetAllMotionPictureRecords(CancellationToken cancellationToken)
        {
            List<Abstract.MotionPicture> motionPictures = new List<Abstract.MotionPicture>();

            try
            {
                using(SqlConnection conn = new SqlConnection(context.ConnectionString))
            }
            return null;
            
        }


        string connString = context.
        #region Sql Commands 

        #endregion
    }
}
