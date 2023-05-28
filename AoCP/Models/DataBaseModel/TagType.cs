using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    [Table("tag_type")]
    public class TagType
    {
        [Column("tag_type_id")]
        public int ID{ get; set; }
        public string Type { get; set; } = "";
        public List<Tags> Tags { get; set; } = new List<Tags>();
    }
}
