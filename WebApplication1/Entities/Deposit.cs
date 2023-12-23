using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Entities
{
    public class Deposit : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int? Amount { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now;

        public int PersonId { get; set; }
        //[NotMapped]
        //public Person? Person { get; set; }
        
        public int DepositTypeId { get; set; }
        //[NotMapped]
        //public DepositType? DepositType { get; set; }

        public int CurrencyId { get; set; }
        //[NotMapped]
        //public Currency? Currency { get; set; }

    }
}
