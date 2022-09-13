using Abstractions.MotionPicture;
using Data.DAO.MotionPicture;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Abstract = Abstractions.MotionPicture.Models;

namespace Data.MotionPicture
{
    public class MotionPictureRepository : IMotionPictureRepository 
    {
        public MotionPictureRepository(string connString)
        {
            this.connString = connString;
        }

        /// <summary>
        /// Gets All Motion Pictures 
        /// </summary>
        /// <returns>List of Motion Pictures</returns>
        public async Task<List<Abstract.MotionPicture>> GetAllMotionPictureRecords()
        {
            List<Abstract.MotionPicture> motionPictures = new List<Abstract.MotionPicture>();

            try
            {
                using(SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    
                    SqlCommand cmd = new SqlCommand(AllMotionPictures, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        motionPictures.Add(rowToObject(rdr));
                    }

                }
            }
            catch (SqlException)
            {
                throw;
            }

            return motionPictures;
        }

        /// <summary>
        /// Get Motion Picture By Id 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>MotionPicture</returns>
        public async Task<Abstract.MotionPicture> GetMotionPictureById(int id)
        {
            Abstract.MotionPicture motionPicture = new Abstract.MotionPicture();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(GetMotionPicture_ById, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        motionPicture = rowToObject(rdr);
                    }

                }
            }
            catch (SqlException)
            {
                throw;
            }

            return motionPicture;
        }

        /// <summary>
        /// Add Motion Picture 
        /// </summary>
        /// <param name="input">Input Motion Picture</param>
        /// <returns>New Motion Picture</returns>
        public async Task<Abstract.MotionPicture> AddMotionPicture(Abstract.MotionPicture input)
        {
            Abstract.MotionPicture result = new Abstract.MotionPicture();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Add_MotionPicture, conn);
                    cmd.Parameters.AddWithValue("@name", input.Name);
                    cmd.Parameters.AddWithValue("@description", input.Description);
                    cmd.Parameters.AddWithValue("@releaseyear", input.ReleaseYear);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        result = rowToObject(rdr);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return result;

        }

        /// <summary>
        /// Updates Motion Picture 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<bool> UpdateMotionPicture(Abstract.MotionPicture input)
        {
            bool success = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Update_MotionPicture, conn);
                    cmd.Parameters.AddWithValue("@name", input.Name);
                    cmd.Parameters.AddWithValue("@description", input.Description);
                    cmd.Parameters.AddWithValue("@releaseyear", input.ReleaseYear);
                    cmd.Parameters.AddWithValue("@id", input.Id);
                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        success = true;
                    }
                    else success = false;
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return success;
        }

        /// <summary>
        /// Deletes Motion Picture
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>True or False whether the Motion Picture can be Deleted</returns>
        public async Task<bool> DeleteMotionPictureById(int id)
        {
            bool success = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(delete_motionPicture, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        success = true;
                    }
                    else success = false;
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return success;
        }

        #region Sql Commands 
        private readonly string connString;
        private const string AllMotionPictures = "SELECT * FROM MotionPictures";
        private const string GetMotionPicture_ById = "Select * FROM MotionPictures WHERE ID = @id";
        private const string Add_MotionPicture = "insert into MotionPictures (name, description, releaseyear) values (@name, @description, @releaseyear)";
        private const string Update_MotionPicture = "UPDATE MotionPictures Set Name = @name, description = @description, releaseYear = @releaseyear Where id = @id";
        private const string delete_motionPicture = "DELETE from MotionPicture WHERE id = @id";
        #endregion

        #region Helpers
            private Abstract.MotionPicture rowToObject(SqlDataReader rdr)
        {
            Abstract.MotionPicture motionPicture = new Abstract.MotionPicture()
            {
                Id = Convert.ToInt32(rdr["ID"]),
                Description = Convert.ToString(rdr["Description"]),
                Name = Convert.ToString(rdr["Name"]),
                ReleaseYear = Convert.ToInt32(rdr["ReleaseYear"])
            };

            return motionPicture;
        }
        #endregion
    }
}
