namespace MotionPictureManagement.MotionPicture.Dtos
{
    public class MotionPictureDto
    {
        /// <summary>
        /// Unqiue Id per Motion Picture
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of Motion Picture
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Description of Motion Picture
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Year a Motion Picture was Released
        /// </summary>
        public int ReleaseYear { get; set; }
    }
}
