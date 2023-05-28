using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    public class Object
    {
        [Column("object_id")]
        public int Id { get; set; }
        [Column("Landlord_id")]
        public int LendlordId { get; set; }
        [Column("place_count")]
        public int PlaceCount { get; set; }
        public string Street { get; set; }="";
        public int House { get; set; }
        public int Building { get; set; }
        public string Name { get; set; }="";

        public List<Place> Places { get; set; } = new List<Place>();

        [ForeignKey("LendlordId")] public Landlord Lendlord { get; set; } = new Landlord();
    }
}
