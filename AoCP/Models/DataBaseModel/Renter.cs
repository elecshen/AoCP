using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    [Table("renter_data")]
    public class Renter
    {

        [Key]
        public int ID { get; set; }
        [Column("last_name")]
        public string LastName { get; set; } = "";
        [Column("first_name")]
        public string FirstName { get; set; } = "";
        public string Patronymic { get; set; } = "";
        [Column("phone_number")]
        public string PhoneNumber { get; set; } = "";


        [ForeignKey("ID")]
        public User User { get; set; }
        [InverseProperty("Renter")]
        public List<Reserves> Reserves { get; set; } = new List<Reserves>();
        [InverseProperty("Renter")]

        public List<Feedbacks> Feedbacks { get; set; } = new List<Feedbacks>();
    }
}
