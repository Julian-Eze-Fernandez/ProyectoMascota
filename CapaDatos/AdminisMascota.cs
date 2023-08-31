using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;

namespace CapaDatos
{
    public class AdminisMascota : DatosConexion
    {
        #region ABMROTA
        //public int abmMascotas(string accion, Mascota objMascota)
        //{
        //    int resultado = -1; //Controlar que se realice la operacion con exito.
        //    string orden = string.Empty; //Para guardar consulta sql.

        //    //Agregar una Mascota nueva.
        //    if (accion == "Alta")
        //    {
        //        orden = "insert into Mascota values ('" + objMascota.Codigo + "," + objMascota.NombreMascota + ",'" + objMascota.Edad + "," + objMascota.Tipo + "," + objMascota.Sexo + ",'" + objMascota.Peso + "," + objMascota.UltimoControl + "');";
        //    }


        //    //Para modificar un existente.
        //    if (accion == "Modificar")
        //    {
        //        orden = "update Mascota set NombreMascota='" + objMascota.NombreMascota + "', Edad= " + objMascota.Edad + "', Tipo= " + objMascota.Tipo + "', Sexo= " + objMascota.Sexo + "', Peso= " + objMascota.Peso + "' ";
        //    }


        //    // Para borrar una Mascota.
        //    if (accion == "Borrar")
        //    {
        //        orden = "delete from Mascota where Codigo= " + objMascota.Codigo + "; ";
        //    }

        //    OleDbCommand cmd = new OleDbCommand(orden, conexion);

        //    try
        //    {
        //        Abrirconexion();
        //        resultado = cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("Errror al tratar de alta,borrar o modificar de Mascota", e);
        //        //throw new Exception($"Error de la accion {accion}", e);
        //    }
        //    finally
        //    {
        //        Cerrarconexion();
        //        cmd.Dispose();
        //    }
        //    return resultado;
        //}

        //public DataSet listadoMascotas(string cual) //Para 1 o todos los datos segun el codigo.
        //{
        //    string orden = string.Empty;

        //    if (cual != "Todos")
        //        orden = "select * from Mascota where Codigo = " + int.Parse(cual) + ";";
        //    else
        //        orden = "select * from Mascota;";

        //    OleDbCommand cmd = new OleDbCommand(orden, conexion);

        //    DataSet ds = new DataSet();

        //    OleDbDataAdapter da = new OleDbDataAdapter();

        //    try
        //    {
        //        Abrirconexion();
        //        cmd.ExecuteNonQuery();
        //        da.SelectCommand = cmd;
        //        da.Fill(ds);
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("Error al listar mascotas", e);
        //    }
        //    finally
        //    {
        //        Cerrarconexion();
        //        cmd.Dispose();
        //    }
        //    return ds;
        //}
        #endregion

        public int abmMascotas(string accion, Mascota objMascota)
        {
            int resultado = -1;  // controlar que se realize la operacion con exito
            string orden = string.Empty; // para guardar consulta sql
            if (accion == "Alta") // para agregar un producto nuevo
            {
                orden = $"insert into Mascota (Codigo, NombreMascota, Edad, Tipo, Sexo, Peso, Vacunada, Castrada, UltimoControl) values ({objMascota.Codigo}, '{objMascota.NombreMascota}', {objMascota.Edad},' {objMascota.Tipo}', '{objMascota.Sexo}' , {objMascota.Peso}, {objMascota.Vacunada},{objMascota.Castrada},'{objMascota.UltimoControl}' );";
            }

            if (accion == "Modificar") // para modificar un existente
                orden = $"update Mascota set NombreMascota='{objMascota.NombreMascota}', Edad={objMascota.Edad}, Tipo='{objMascota.Tipo}', Sexo='{objMascota.Sexo}', Peso={objMascota.Peso}, Vacunada={objMascota.Vacunada}, Castrada={objMascota.Castrada}, UltimoControl='{objMascota.UltimoControl}' WHERE codigo Like '%{objMascota.Codigo}%';";


            if (accion == "Borrar") // para borrar un existente
                orden = "delete * from Mascota where Codigo =" + objMascota.Codigo + ";";


            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Error de la accion {accion}", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoMascotas(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select * from Mascota where Codigo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Mascota;";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar mascotas", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
