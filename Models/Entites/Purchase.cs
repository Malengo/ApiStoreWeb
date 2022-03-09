using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiStoreWeb.Models.Entites
{
    public class Purchase

    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public virtual Smartphone smartphoneId { get; set; }
        public DateTime dayPurchase { get; set; }
        public double valuePurchase { get; set; }

    }
}
