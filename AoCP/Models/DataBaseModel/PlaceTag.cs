using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    [Table("place_tag")]

    public class PlaceTag
    {

        public int  ID { get; set; }
        [Column("tag_id")]
        public int  TagID { get; set; }
        [Column("place_id")]

        public int  PlaceID { get; set; }

    }
}
