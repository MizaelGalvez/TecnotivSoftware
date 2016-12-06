namespace InterfaceTIV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbtecnotiv.configuracion")]
    public partial class configuracion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idConfiguracion { get; set; }

        public int? lbl_idioma { get; set; }

        public bool? uso_silla { get; set; }

        public bool? uso_diadema { get; set; }

        public bool? uso_Mause { get; set; }

        public bool? uso_Sensor { get; set; }

        [StringLength(45)]
        public string lbl_Usuario { get; set; }
    }
}
