using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceTIV.Model;
using System.Data.Entity;
using Emotiv;
using System.Web;
using System.Net;
using System.IO;

namespace InterfaceTIV.Model
{
    class Acciones
    {
        /////////////////////////////////////////////////vista Configuracion/////////////////////////////////////////////////
        // 
        //
        //
        //
        //
        //
        public static void Guardar(configuracion nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idConfiguracion > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void EliminarComidas(comidas nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idComidas > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void EliminarBebidas(bebidas nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idBebidas > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void EliminarPostres(postres nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idPostres > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void EliminarActividades(actitidades nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idActitidades > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void EliminarEntretenimiento(internet nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idInternet > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public  static string usuario( int Id)
        {
            string valor = "";
            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.configuracion
                                  where dato.idConfiguracion == Id
                                  select dato.lbl_Usuario);

                    //Console.WriteLine(user.ToString());

                    foreach (var result in user)
                    {
                          valor = result.ToString();
                    }


                    return valor;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string contraseña(int Id)
        {
            string valor = "";
            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.configuracion
                                where dato.idConfiguracion == Id
                                select dato.txtContraseña);

                    //Console.WriteLine(user.ToString());

                    foreach (var result in user)
                    {
                        valor = result.ToString();
                    }


                    return valor;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int idioma(int Id)
        {
            int valor=0;
            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.configuracion
                                where dato.idConfiguracion == Id
                                select dato.lbl_idioma);

                    //Console.WriteLine(user.ToString());

                    foreach (var result in user)
                    {           
                        valor = (int)result;
                        Console.WriteLine(valor);
                    }


                    return valor;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public static bool isChecked_diadema(int Id)
        {
            bool valor = false;

            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.configuracion
                                where dato.idConfiguracion == Id
                                select dato.uso_diadema);

                    //Console.WriteLine(user.ToString());

                    foreach (var result in user)
                    {
                        
                        if ((int)result == 1 )
                        {

                            valor = true;

                        }
                    }


                    return valor;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool isChecked_silla(int Id)
        {
            bool valor = false;

            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.configuracion
                                where dato.idConfiguracion == Id
                                select dato.uso_silla);

                    //Console.WriteLine(user.ToString());

                    foreach (var result in user)
                    {
                        if ((int)result == 1)
                        {

                            valor = true;

                        }
                    }


                    return valor;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool isChecked_mause(int Id)
        {
            bool valor = false;

            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.configuracion
                                where dato.idConfiguracion == Id
                                select dato.uso_Mause);

                    //Console.WriteLine(user.ToString());

                    foreach (var result in user)
                    {
                        if ((int)result == 1)
                        {

                            valor = true;

                        }
                    }


                    return valor;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool isChecked_sensor(int Id)
        {
            bool valor = false;

            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.configuracion
                                where dato.idConfiguracion == Id
                                select dato.uso_Sensor);

                    //Console.WriteLine(user.ToString());

                    foreach (var result in user)
                    {
                        if ((int)result == 1)
                        {

                            valor = true;

                        }
                    }


                    return valor;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //
        //
        //
        //
        //
        //
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 



        //////////////////////////////////////////////Obtener Valores para PANEL AUTOMATICO///////////////////////////////////
        //
        //
        //
        //
        //
        // 
        public static string[,] ObtenerComidas()
        {
            
            bool bactivo = true;
            string valor = "";
            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.comidas
                                where dato.bactivo == bactivo
                                select dato.lbl_Nombre);


                    int i = 0;
                    string[,] Datos = new string[user.Count(), 5];
                    
                    foreach (var result in user )
                    {
                          valor = result.ToString();
                          Datos[i,0] = valor;
                          i++;
                    }

                    using (var ctx2 = new Model1())
                    {
                        var user1 = (from dato2 in ctx2.comidas
                                    where dato2.bactivo == bactivo
                                   select dato2.img_Ruta);
                        
                        i = 0;
                        
                        foreach (var result2 in user1)
                        {
                            valor = result2.ToString();
                            Datos[i, 1] = valor;
                            i++;
                        }

                        using (var ctx3 = new Model1())
                        {
                            var user3 = (from dato3 in ctx3.comidas
                                         where dato3.bactivo == bactivo
                                         select dato3.lbl_Descripcion);

                            i = 0;

                            foreach (var result3 in user3)
                            {
                                valor = result3.ToString();
                                Datos[i, 2] = valor;
                                i++;
                            }

                            using (var ctx4 = new Model1())
                            {
                                var user4 = (from dato4 in ctx4.comidas
                                             where dato4.bactivo == bactivo
                                             select dato4.idComidas);

                                i = 0;

                                foreach (var result4 in user4)
                                {
                                    valor = result4.ToString();
                                    Datos[i, 4] = valor;
                                    i++;
                                }

                                return Datos;

                            }

                        }

                    }



                }
               
                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string[,] ObtenerBebidas()
        {

            bool bactivo = true;
            string valor = "";
            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.bebidas
                                where dato.bactivo == bactivo
                                select dato.lbl_Nombre);


                    int i = 0;
                    string[,] Datos = new string[user.Count(), 5];

                    foreach (var result in user)
                    {
                        valor = result.ToString();
                        Datos[i, 0] = valor;
                        i++;
                    }

                    using (var ctx2 = new Model1())
                    {
                        var user1 = (from dato2 in ctx2.bebidas
                                     where dato2.bactivo == bactivo
                                     select dato2.img_Ruta);

                        i = 0;

                        foreach (var result2 in user1)
                        {
                            valor = result2.ToString();
                            Datos[i, 1] = valor;
                            i++;
                        }

                        using (var ctx3 = new Model1())
                        {
                            var user3 = (from dato3 in ctx3.bebidas
                                         where dato3.bactivo == bactivo
                                         select dato3.lbl_Descripcion);

                            i = 0;

                            foreach (var result3 in user3)
                            {
                                valor = result3.ToString();
                                Datos[i, 2] = valor;
                                i++;
                            }

                            using (var ctx4 = new Model1())
                            {
                                var user4 = (from dato4 in ctx4.bebidas
                                             where dato4.bactivo == bactivo
                                             select dato4.idBebidas);

                                i = 0;

                                foreach (var result4 in user4)
                                {
                                    valor = result4.ToString();
                                    Datos[i, 4] = valor;
                                    i++;
                                }

                                return Datos;

                            }

                        }

                    }



                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string[,] ObtenerPostres()
        {

            bool bactivo = true;
            string valor = "";
            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.postres
                                where dato.bactivo == bactivo
                                select dato.lbl_Nombre);


                    int i = 0;
                    string[,] Datos = new string[user.Count(), 5];

                    foreach (var result in user)
                    {
                        valor = result.ToString();
                        Datos[i, 0] = valor;
                        i++;
                    }

                    using (var ctx2 = new Model1())
                    {
                        var user1 = (from dato2 in ctx2.postres
                                     where dato2.bactivo == bactivo
                                     select dato2.img_Ruta);

                        i = 0;

                        foreach (var result2 in user1)
                        {
                            valor = result2.ToString();
                            Datos[i, 1] = valor;
                            i++;
                        }

                        using (var ctx3 = new Model1())
                        {
                            var user3 = (from dato3 in ctx3.postres
                                         where dato3.bactivo == bactivo
                                         select dato3.lbl_Descripcion);

                            i = 0;

                            foreach (var result3 in user3)
                            {
                                valor = result3.ToString();
                                Datos[i, 2] = valor;
                                i++;
                            }

                            using (var ctx4 = new Model1())
                            {
                                var user4 = (from dato4 in ctx4.postres
                                             where dato4.bactivo == bactivo
                                             select dato4.idPostres);

                                i = 0;

                                foreach (var result4 in user4)
                                {
                                    valor = result4.ToString();
                                    Datos[i, 4] = valor;
                                    i++;
                                }

                                return Datos;

                            }

                        }

                    }



                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string[,] ObtenerActividades()
        {

            bool bactivo = true;
            string valor = "";
            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.actitidades
                                where dato.bactivo == bactivo
                                select dato.lbl_NombreActividad);


                    int i = 0;
                    string[,] Datos = new string[user.Count(), 5];

                    foreach (var result in user)
                    {
                        valor = result.ToString();
                        Datos[i, 0] = valor;
                        i++;
                    }

                    using (var ctx2 = new Model1())
                    {
                        var user1 = (from dato2 in ctx2.actitidades
                                     where dato2.bactivo == bactivo
                                     select dato2.img_Ruta);

                        i = 0;

                        foreach (var result2 in user1)
                        {
                            valor = result2.ToString();
                            Datos[i, 1] = valor;
                            i++;
                        }

                        using (var ctx4 = new Model1())
                        {
                            var user4 = (from dato4 in ctx4.actitidades
                                         where dato4.bactivo == bactivo
                                         select dato4.idActitidades);

                            i = 0;

                            foreach (var result4 in user4)
                            {
                                valor = result4.ToString();
                                Datos[i, 4] = valor;
                                i++;
                            }

                            return Datos;

                        }

                    }



                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string[,] ObtenerEntretenimiento()
        {

            bool bactivo = true;
            string valor = "";
            try
            {
                using (var ctx = new Model1())
                {
                    var user = (from dato in ctx.internet
                                where dato.bactivo == bactivo
                                select dato.lbl_Nombre);


                    int i = 0;
                    string[,] Datos = new string[user.Count(), 5];

                    foreach (var result in user)
                    {
                        valor = result.ToString();
                        Datos[i, 0] = valor;
                        i++;
                    }

                    using (var ctx2 = new Model1())
                    {
                        var user1 = (from dato2 in ctx2.internet
                                     where dato2.bactivo == bactivo
                                     select dato2.img_Ruta);

                        i = 0;

                        foreach (var result2 in user1)
                        {
                            valor = result2.ToString();
                            Datos[i, 1] = valor;
                            i++;
                        }

                        using (var ctx3 = new Model1())
                        {
                            var user3 = (from dato3 in ctx3.internet
                                         where dato3.bactivo == bactivo
                                         select dato3.lbl_Url);

                            i = 0;

                            foreach (var result3 in user3)
                            {
                                valor = result3.ToString();
                                Datos[i, 2] = valor;
                                i++;
                            }

                            using (var ctx4 = new Model1())
                            {
                                var user4 = (from dato4 in ctx4.internet
                                             where dato4.bactivo == bactivo
                                             select dato4.idInternet);

                                i = 0;

                                foreach (var result4 in user4)
                                {
                                    valor = result4.ToString();
                                    Datos[i, 4] = valor;
                                    i++;
                                }

                                return Datos;

                            }

                        }
                    }



                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        //
        //
        //
        //
        //
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////Guardados de los diferentes Paneles///////////////////////////////////
        //
        //
        //
        //
        //
        //
        public static void GuardarComida(comidas nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idComidas > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void GuardarBebidas(bebidas nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idBebidas > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void GuardarPostres(postres nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idPostres > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void GuardarActividades(actitidades nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idActitidades > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void GuardarInternet(internet nEntrada)
        {
            try
            {
                using (var ctx = new Model1())
                {
                    if (nEntrada.idInternet > 0)
                    {
                        ctx.Entry(nEntrada).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nEntrada).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //
        //
        //
        //
        //
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
