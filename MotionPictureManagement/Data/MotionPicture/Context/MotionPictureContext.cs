using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract = Abstractions.MotionPicture.Models;

namespace Data.MotionPicture.Context
{
    public class MotionPictureContext : DbContext
    {
        public MotionPictureContext(DbContextOptions<MotionPictureContext> options) : base(options) { }

        public DbSet<Abstract.MotionPicture> MotionPictures { get; set; }
    }
}
