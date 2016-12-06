namespace InterfaceTIV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dbtecnotiv.texto")]
    public partial class texto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTexto { get; set; }

        [StringLength(45)]
        public string lblNombre { get; set; }

        [StringLength(45)]
        public string lblEspañol { get; set; }

        [StringLength(45)]
        public string lblEnglish { get; set; }

        public bool? bActivo { get; set; }
    }
}
