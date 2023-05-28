using System.ComponentModel.DataAnnotations;

namespace AoCP.Models.DataBaseModel
{
    public class Object
    {
        [Key]
        public int Object_Id { get; set; }
        public int Arendodatel_Id { get; set; }
        public string Place { get; set; } = "";
        public string Street { get; set; }= "";
        public string House { get; set; }= "";
        public string Building { get; set; }= "";
        public string Name { get; set; } = "";
    }
}
