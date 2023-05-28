using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    public class Reserves
    {
        [Column("reserv_id")]
        public int ID { get; set; }
        [Column("renter_id")]
        public int RenterID { get; set; }
        [Column("place_id")]
        public int PlaceID { get; set; }
        [Column("start_date")]
        public DateTime StartDate { get; set; }
        [Column("end_date")]
        public DateTime EndDate { get; set; }
        [Column("status_id")]
        public int StatusID { get; set; }
        
        
        
        [ForeignKey("RenterID")]
        public Renter Renter { get; set; } = new Renter();
        [ForeignKey("PlaceID")]
        public Place Place { get; set; } = new Place();
        [ForeignKey("StatusID")] 
        public Status Status { get; set; } = new Status(); 
    }
}
