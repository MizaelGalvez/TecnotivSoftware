namespace InterfaceTIV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbtecnotiv.bebidas")]
    public partial class bebidas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idBebidas { get; set; }

        [StringLength(45)]
        public string lbl_Nombre { get; set; }

        [StringLength(45)]
        public string lbl_Descripcion { get; set; }

        [StringLength(45)]
        public string lbl_Receta { get; set; }

        [StringLength(145)]
        public string img_Ruta { get; set; }

        public bool bactivo { get; set; }
    }
}
