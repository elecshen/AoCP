using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    [Table("place_image")]

    public class PlaceImage
    {
        [Key]
        [Column("image_id")]
        public int Id { get; set; }
        [Column("place_id")]
        public int PlaceId { get; set; }
        [Column("image_reference")]
        public string ImageReference { get; set; } = "";

    }
}
