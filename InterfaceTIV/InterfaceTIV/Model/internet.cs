namespace InterfaceTIV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbtecnotiv.internet")]
    public partial class internet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idInternet { get; set; }

        [StringLength(45)]
        public string lbl_Nombre { get; set; }

        [StringLength(145)]
        public string lbl_Url { get; set; }

        [StringLength(145)]
        public string img_Ruta { get; set; }

        public bool? bactivo { get; set; }
    }
}
