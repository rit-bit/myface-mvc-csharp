using System.ComponentModel.DataAnnotations;

namespace MyFace.Models.Request
{
    public class DeleteUserRequestModel
    {
        [Required]
        public int UserId { get; set; }
    }
}