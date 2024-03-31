namespace EntityProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personeller")]
    public partial class Personeller
    {
        [Key]
        public int PersonelID { get; set; }

        public int? BirimID { get; set; }

        [StringLength(50)]
        public string AdiSoyadi { get; set; }

        [StringLength(11)]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string Adres { get; set; }

        [Column(TypeName = "text")]
        public string Email { get; set; }

        [StringLength(50)]
        public string Tarih { get; set; }

        public bool? IsActive { get; set; }
    }
}
