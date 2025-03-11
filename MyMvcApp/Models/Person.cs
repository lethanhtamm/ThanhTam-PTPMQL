using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMvcApp.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public required String PersonID { get; set; }
        public required String FullName { get; set; }
        public required String Address { get; set; }
        public string? Gender { get; internal set; }
        public string? Id { get; internal set; }
    }
}