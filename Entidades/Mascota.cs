using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        #region Atributos
        private int codigo;
        private string nombreMascota;
        private int edad;
        private string tipo;
        private string sexo;
        private decimal peso;
        private bool vacunada;
        private bool castrada;
        DateTime ultimoControl;
        #endregion

        #region Constructores
        public Mascota()
        {
        }

        public Mascota(int cod, string nom, int ed, string tip, string sex, decimal pes, bool vac, bool cas, DateTime ultctrl)
        {
            codigo = cod;
            nombreMascota = nom;
            edad = ed;
            tipo = tip;
            sexo = sex;
            peso = pes;
            vacunada = vac;
            castrada = cas;
            ultimoControl = ultctrl;

        }
        #endregion


        #region Propiedades

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string NombreMascota { get { return nombreMascota; } set { nombreMascota = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public decimal Peso { get { return peso; } set { peso = value; } }
        public DateTime UltimoControl { get { return ultimoControl; } set { ultimoControl = value; } }
        public bool Vacunada { get { return vacunada; } set { vacunada = value; } }
        public bool Castrada { get { return castrada; } set { castrada = value; } }
        #endregion
    }
}
