using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    public class Status
    {
        [Column("status_id")]
        [Key]
        public int ID {get;set;}
        public string Name { get; set; } = "";
    }
}
