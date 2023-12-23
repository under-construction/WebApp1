using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Entities
{
    public class Person : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; } = 0;
        public DateTime? BirthDate { get; set; }
        public int TotalMoney { get; set; } = 0;

        //[NotMapped]
        public IEnumerable<Deposit> Deposits { get; set; } = new List<Deposit>();
    }
}
