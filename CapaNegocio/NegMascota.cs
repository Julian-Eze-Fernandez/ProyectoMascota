using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegMascota
    {
        AdminisMascota DatosObjMascota = new AdminisMascota();

        public int abmMascotas(string accion, Mascota objMasocta)
        {
            return DatosObjMascota.abmMascotas(accion, objMasocta);
        }

        public DataSet listadoMascotas(string cual)
        {
            return DatosObjMascota.listadoMascotas(cual);
        }
    }
}
