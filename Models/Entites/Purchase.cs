using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiStoreWeb.Models
{
    public class Purchase

    {
        public Purchase(int idPurchase, DateTime dayPurchase, double valuePurchase)
        {
            IdPurchase = idPurchase;
            this.dayPurchase = dayPurchase;
            this.valuePurchase = valuePurchase;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPurchase { get; set; }

        [ForeignKey("Id")]
        public virtual Smartphone smartphoneId { get; set; }
        public DateTime dayPurchase { get; set; }
        public double valuePurchase { get; set; }

    }
}
