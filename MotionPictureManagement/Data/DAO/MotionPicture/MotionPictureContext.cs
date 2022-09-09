using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels = Data.DAO.MotionPicture.Models;

namespace Data.DAO.MotionPicture
{
    public class MotionPictureContext : DbContext
    {
        public MotionPictureContext(DbContextOptions<MotionPictureContext> options) : base(options) { }
        
        public DbSet<DataModels.MotionPicture> MotionPictures { get; set; }
    }
}
