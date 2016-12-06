namespace InterfaceTIV.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<acondicionado> acondicionado { get; set; }
        public virtual DbSet<actitidades> actitidades { get; set; }
        public virtual DbSet<bebidas> bebidas { get; set; }
        public virtual DbSet<comidas> comidas { get; set; }
        public virtual DbSet<configuracion> configuracion { get; set; }
        public virtual DbSet<contacto> contacto { get; set; }
        public virtual DbSet<dolores> dolores { get; set; }
        public virtual DbSet<internet> internet { get; set; }
        public virtual DbSet<postres> postres { get; set; }
        public virtual DbSet<televisiones> televisiones { get; set; }
        public virtual DbSet<texto> texto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<acondicionado>()
                .Property(e => e.lbl_Marca)
                .IsUnicode(false);

            modelBuilder.Entity<acondicionado>()
                .Property(e => e.codigo_Television)
                .IsUnicode(false);

            modelBuilder.Entity<actitidades>()
                .Property(e => e.lbl_NombreActividad)
                .IsUnicode(false);

            modelBuilder.Entity<bebidas>()
                .Property(e => e.lbl_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<bebidas>()
                .Property(e => e.lbl_Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<bebidas>()
                .Property(e => e.lbl_Receta)
                .IsUnicode(false);

            modelBuilder.Entity<bebidas>()
                .Property(e => e.img_Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<comidas>()
                .Property(e => e.lbl_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<comidas>()
                .Property(e => e.lbl_Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<comidas>()
                .Property(e => e.lbl_Receta)
                .IsUnicode(false);

            modelBuilder.Entity<comidas>()
                .Property(e => e.img_Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<configuracion>()
                .Property(e => e.lbl_Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<contacto>()
                .Property(e => e.lbl_NombrePersona)
                .IsUnicode(false);

            modelBuilder.Entity<contacto>()
                .Property(e => e.lbl_NumeroCelular)
                .IsUnicode(false);

            modelBuilder.Entity<contacto>()
                .Property(e => e.lbl__NumeroCasa)
                .IsUnicode(false);

            modelBuilder.Entity<dolores>()
                .Property(e => e.lbl_Lugar)
                .IsUnicode(false);

            modelBuilder.Entity<dolores>()
                .Property(e => e.lbl_SolucionIntenso)
                .IsUnicode(false);

            modelBuilder.Entity<dolores>()
                .Property(e => e.lbl_SolucionModerado)
                .IsUnicode(false);

            modelBuilder.Entity<dolores>()
                .Property(e => e.lbl_SolucionLeve)
                .IsUnicode(false);

            modelBuilder.Entity<internet>()
                .Property(e => e.lbl_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<internet>()
                .Property(e => e.lbl_Url)
                .IsUnicode(false);

            modelBuilder.Entity<internet>()
                .Property(e => e.img_Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<postres>()
                .Property(e => e.lbl_Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<postres>()
                .Property(e => e.lbl_Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<postres>()
                .Property(e => e.lbl_Receta)
                .IsUnicode(false);

            modelBuilder.Entity<postres>()
                .Property(e => e.img_Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<televisiones>()
                .Property(e => e.lbl_Marca)
                .IsUnicode(false);

            modelBuilder.Entity<televisiones>()
                .Property(e => e.codigo_Television)
                .IsUnicode(false);

            modelBuilder.Entity<texto>()
                .Property(e => e.lblNombre)
                .IsUnicode(false);

            modelBuilder.Entity<texto>()
                .Property(e => e.lblEspañol)
                .IsUnicode(false);

            modelBuilder.Entity<texto>()
                .Property(e => e.lblEnglish)
                .IsUnicode(false);
        }
    }
}
