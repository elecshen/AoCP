using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    public class Tags
    {
        [Column("tag_id")]
        public int ID { get; set; }
        public string Tag { get; set; } = "";
        [Column("tag_type_id")]
        public int TagTypeID { get; set; }
        [ForeignKey("TagTypeID")]
        public TagType TagType { get; set; } = new TagType();


    }
}
