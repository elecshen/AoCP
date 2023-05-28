using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    [Table("landlord_data")]
    public class Landlord
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
        public string Title { get; set; } = "";
        [Column("legal_entity_name")]
        public string LegalEntityName { get; set; } = "";
        public string INN { get; set; } = "";


        [ForeignKey("ID")]
        public User User { get; set; }

        public List<Object> Objects { get; set; }

        public List<Reserves> Reserves { get; set; }


    }
}
