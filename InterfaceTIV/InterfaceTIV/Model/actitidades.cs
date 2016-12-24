namespace InterfaceTIV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbtecnotiv.actitidades")]
    public partial class actitidades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idActitidades { get; set; }

        [StringLength(45)]
        public string lbl_NombreActividad { get; set; }

        [StringLength(145)]
        public string img_Ruta { get; set; }

        public bool? bactivo { get; set; }
    }
}
