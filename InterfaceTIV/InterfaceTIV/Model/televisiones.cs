namespace InterfaceTIV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbtecnotiv.televisiones")]
    public partial class televisiones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idtelevisiones { get; set; }

        [StringLength(45)]
        public string lbl_Marca { get; set; }

        [StringLength(200)]
        public string codigo_Television { get; set; }

        public bool? bactivo { get; set; }
    }
}
