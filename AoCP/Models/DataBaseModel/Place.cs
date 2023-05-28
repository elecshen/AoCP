using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    public class Place
    {

        public int ID { get; set; }
        public int Price { get; set; }
        [Column("is_all_day")]
        public int IsAllDay { get; set; }
        [Column("object_id")]
        public int ObjectID { get; set; }
        public int Capacity { get; set; }

        [ForeignKey("ObjectID")] public Object Object { get; set; } = new Object();

        public List<Reserves> Reserves { get; set; } = new List<Reserves>();
        public List<PlaceTag> PlaceTags { get; set; } = new List<PlaceTag>();
        public List<PlaceImage> PlaceImages { get; set; } = new List<PlaceImage>();
        public List<Services> Services { get; set; } = new List<Services>();



    }
}
