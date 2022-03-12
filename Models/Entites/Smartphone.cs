using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiStoreWeb.Models.Entites
{
    public class Smartphone
    {


        public Smartphone(int id, string? brand, string? modelDescription, string? color, string? capacity, string memory, double imeiOne, double imeiTwo)
        {
            Id = id;
            Brand = brand;
            this.modelDescription = modelDescription;
            Color = color;
            Capacity = capacity;
            Memory = memory;
            ImeiOne = imeiOne;
            ImeiTwo = imeiTwo;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? modelDescription { get; set; }
        public string? Color { get; set; }
        public string? Capacity { get; set; }
        public string? Memory { get; set; }
        public double ImeiOne { get; set; }
        public double ImeiTwo { get; set; }


    }

}
