using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AoCP.Models.DataBaseModel
{
    [Table("User")]
    public class User
    {
        [Key]
        public int ID { get; set; }

        public string Mail { get; set; } = "@mail.";
        public string Password { get; set; } = "";
        [Column("account_type")]
        public int AccountType { get; set; }

        //указать существование в OnModelCreating
        public Landlord Landlord { get; set; }

        public  Renter Renter { get; set; } 
        public object? GetAccount()
        {
            switch (AccountType)
            {
                case (int)TypeAccount.Landlord:
                    return Landlord;
                case (int)TypeAccount.Renter: 
                    return Renter;
                case (int)TypeAccount.Administrator:
                    return Landlord;
                default:
                    return null;
            }
        }
    }
    enum TypeAccount
    {
        Landlord = 1,
        Renter = 2,
        Administrator = 3,

    }
}
