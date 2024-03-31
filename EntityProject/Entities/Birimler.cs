namespace EntityProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Birimler")]
    public partial class Birimler
    {
        [Key]
        public int BirimID { get; set; }

        [StringLength(50)]
        public string BirimAdi { get; set; }

        [Column(TypeName = "text")]
        public string Aciklama { get; set; }
    }
}
