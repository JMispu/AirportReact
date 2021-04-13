using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Flight
    {
        [Key]
        public int ID { get; set; }

        public int AirplaneID { get; set; }
        [ForeignKey("AirplaneID")]
        public virtual Airplane Airplane { get; set; }

        public int? StartCityID { get; set; }
        [ForeignKey("StartCityID")]
        public virtual City StartCity { get; set; }

        public int? FinishCityID { get; set; }
        [ForeignKey("FinishCityID")]
        public virtual City FinishCity { get; set; }

        public DateTime Time { get; set; }
    }
}
