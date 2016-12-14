using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceTIV.Model;
using System.Data.Entity;
using InterfaceTIV.Model;
using Emotiv;
using System.Web;
using System.Net;
using System.IO;

namespace InterfaceTIV.Model
{
    class Acciones
    {
        // vista Configuracion

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
                        valor = (int)result-1;
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

        //Vista Configuracion

       

    }
}
