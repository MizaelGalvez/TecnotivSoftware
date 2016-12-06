namespace InterfaceTIV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbtecnotiv.dolores")]
    public partial class dolores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idDolores { get; set; }

        [StringLength(45)]
        public string lbl_Lugar { get; set; }

        [StringLength(150)]
        public string lbl_SolucionIntenso { get; set; }

        [StringLength(150)]
        public string lbl_SolucionModerado { get; set; }

        [StringLength(150)]
        public string lbl_SolucionLeve { get; set; }

        public bool bactivo { get; set; }
    }
}
