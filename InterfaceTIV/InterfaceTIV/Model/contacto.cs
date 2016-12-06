namespace InterfaceTIV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbtecnotiv.contacto")]
    public partial class contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUrgencia { get; set; }

        [StringLength(45)]
        public string lbl_NombrePersona { get; set; }

        [StringLength(45)]
        public string lbl_NumeroCelular { get; set; }

        [Column("lbl_ NumeroCasa")]
        [StringLength(45)]
        public string lbl__NumeroCasa { get; set; }

        public bool bactivo { get; set; }
    }
}
