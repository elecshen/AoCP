using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    public class Services
    {
        [Column("services_id")]
        public int ID { get; set; }
        [Column("place_id")]
        public int PlaceID { get; set; }
        public string Name { get; set; } = "";
        public int Price { get; set; }
        public string Desription { get; set; } = "";

        [ForeignKey("PlaceID")] public Place Place { get; set; } = new Place();

    }
}
