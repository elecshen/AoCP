using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    public class Feedbacks
    {

        [Key] public int ID { get; set; }
        public string Text { get; set; } = ""; [Column("place_id")] public int PlaceID { get; set; }
        [Column("renter_id")] 
        public int RenterID { get; set; }

        [ForeignKey("PlaceID")] 
        public Place Place { get; set; } = new Place();
        
        [ForeignKey("RenterID")][InverseProperty("Feedbacks")] 
        public Renter Renter { get; set; } = new Renter();

    }
}
