using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMascota
{
    public partial class FormMascotas : Form
    {
        //DataTable dataMascotas = new DataTable();

        Mascota NuevaMasc;
        Mascota MascExistente;
        public Mascota objEntMasc = new Mascota();
        NegMascota objNegMascota = new NegMascota();
        bool nuevo = true;
        int fila;

        public FormMascotas()
        {
            InitializeComponent();
            CrearDGV();
            LlenarDGV();

            #region CtorViejo
            // dgv_Mascotas.DataSource = dataMascotas;
            //#region Columnas de DGV
            ////Se crean las columnas del DataGridView
            //dataMascotas.Columns.Add("Codigo");
            //dataMascotas.Columns.Add("Nombre");
            //dataMascotas.Columns.Add("Tipo");
            //dataMascotas.Columns.Add("Sexo");
            //dataMascotas.Columns.Add("Edad");
            //dataMascotas.Columns.Add("Peso");
            //dataMascotas.Columns.Add("Ultimo Control");
            //dataMascotas.Columns.Add("Vacunada");
            //dataMascotas.Columns.Add("Castrada");
            //#endregion
            #endregion
        }

        private void LlenarDGV()
        {
            dgv_Mascotas.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegMascota.listadoMascotas("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc...
                    dgv_Mascotas.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                }
            }
            else
                MessageBox.Show("No hay Mascotas cargadas en el sistema.");
        }

        private void CrearDGV()
        {
            dgv_Mascotas.Columns.Add("0", "Código");
            dgv_Mascotas.Columns.Add("1", "Nombre");
            dgv_Mascotas.Columns.Add("2", "Edad");
            dgv_Mascotas.Columns.Add("3", "Tipo");
            dgv_Mascotas.Columns.Add("4", "Sexo");
            dgv_Mascotas.Columns.Add("5", "Peso");
            dgv_Mascotas.Columns.Add("6", "Ultimo Control");
            dgv_Mascotas.Columns.Add("7", "Vacunada");
            dgv_Mascotas.Columns.Add("8", "Castrada");

            dgv_Mascotas.Columns[0].Width = 100;
            dgv_Mascotas.Columns[1].Width = 100;
            dgv_Mascotas.Columns[2].Width = 100;
            dgv_Mascotas.Columns[3].Width = 100;
            dgv_Mascotas.Columns[4].Width = 100;
            dgv_Mascotas.Columns[5].Width = 100;
            dgv_Mascotas.Columns[6].Width = 100;
            dgv_Mascotas.Columns[7].Width = 100;
            dgv_Mascotas.Columns[8].Width = 100;
        }

        public void Limpiar()
        {
            #region PrgViejo
            txt_Codigo.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Edad.Text = string.Empty;
            cmb_Tipo.Text = string.Empty;
            cmb_Sexo.Text = string.Empty;
            txt_Peso.Text = string.Empty;
            radiobtn_SiVacuna.Checked = false;
            radiobtn_NoVacuna.Checked = false;
            radiobtn_SiCastrada.Checked = false;
            radiobtn_NoCastrada.Checked = false;
            #endregion
        }

        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            MascExistente = new Mascota(Convert.ToInt32(dgv_Mascotas.CurrentRow.Cells[0].Value), Convert.ToString(dgv_Mascotas.CurrentRow.Cells[1].Value), Convert.ToInt32(dgv_Mascotas.CurrentRow.Cells[2].Value), Convert.ToString(dgv_Mascotas.CurrentRow.Cells[3].Value), Convert.ToString(dgv_Mascotas.CurrentRow.Cells[4].Value), Convert.ToDecimal(dgv_Mascotas.CurrentRow.Cells[5].Value), Convert.ToBoolean(dgv_Mascotas.CurrentRow.Cells[7].Value), Convert.ToBoolean(dgv_Mascotas.CurrentRow.Cells[8].Value), Convert.ToDateTime(dgv_Mascotas.CurrentRow.Cells[6].Value));

            DataSet ds = new DataSet();
            objEntMasc.Codigo = Convert.ToInt32(dgv_Mascotas.CurrentRow.Cells[0].Value);
            ds = objNegMascota.listadoMascotas(objEntMasc.Codigo.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_controles(ds);

            }
        }

        private void Ds_a_controles(DataSet ds)
        {
            txt_Codigo.Text = ds.Tables[0].Rows[0]["Codigo"].ToString();
            txt_Codigo.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txt_Codigo.Text = ds.Tables[0].Rows[0]["Edad"].ToString();
            txt_Codigo.Text = ds.Tables[0].Rows[0]["Tipo"].ToString();
            txt_Codigo.Text = ds.Tables[0].Rows[0]["Sexo"].ToString();
            txt_Codigo.Text = ds.Tables[0].Rows[0]["Peso"].ToString();
            dateTimePicker1.Value = (DateTime)ds.Tables[0].Rows[0]["UltimoControl"];
            txt_Codigo.Text = ds.Tables[0].Rows[0]["Vacunada"].ToString();
            txt_Codigo.Text = ds.Tables[0].Rows[0]["Castrada"].ToString();
            txt_Codigo.Enabled = false;
        }

        private void atributosTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar) && (e.KeyChar != ',')))
            {
                e.Handled = true;
            }
        }

        private bool ValidarCodigoBorrar()
        {
            bool bandera = false;

            if (!txt_Codigo.Text.Any())
            {
                bandera = true;

                MessageBox.Show(this, "LLENE EL CAMPO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            };
            return bandera;
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            #region PrgViejo
            //Creamos un objeto Nueva masocta de la clase Mascotas con sus atributos
            //Mascota NuevaMascota = new Mascota(int.Parse(txt_Codigo.Text), cmb_Tipo.Text, int.Parse(txt_Edad.Text));

            //Asignacion del valor a las propiedades del objeto NuevaMascota
            //NuevaMascota.NombreMascota = txt_Nombre.Text;
            //NuevaMascota.Sexo = cmb_Sexo.Text;
            //NuevaMascota.Peso = int.Parse(txt_Peso.Text);
            //NuevaMascota.UltimoControl = dateTimePicker1.Value;
            //NuevaMascota.Vacunada = radiobtn_SiVacuna.Checked;
            //NuevaMascota.Castrada = radiobtn_SiCastrada.Checked;

            //Carga de mascotas al DataGridView
            //dataMascotas.Rows.Add();
            //int i = dataMascotas.Rows.Count - 1;

            //dataMascotas.Rows[i]["Codigo"] = NuevaMascota.Codigo;
            //dataMascotas.Rows[i]["Nombre"] = NuevaMascota.NombreMascota;
            //dataMascotas.Rows[i]["Tipo"] = NuevaMascota.Tipo;
            //dataMascotas.Rows[i]["Sexo"] = NuevaMascota.Sexo;
            //dataMascotas.Rows[i]["Edad"] = NuevaMascota.Edad;
            //dataMascotas.Rows[i]["Peso"] = NuevaMascota.Peso;
            //dataMascotas.Rows[i]["Ultimo Control"] = NuevaMascota.UltimoControl.ToShortDateString();
            //dataMascotas.Rows[i]["Vacunada"] = NuevaMascota.Vacunada;
            //dataMascotas.Rows[i]["Castrada"] = NuevaMascota.Castrada;

            //limpiarPantalla();
            #endregion

            int nGrabados = -1;

            Mascota NuevaMascota = new Mascota(int.Parse(txt_Codigo.Text), txt_Nombre.Text, int.Parse(txt_Edad.Text), cmb_Tipo.Text, cmb_Sexo.Text, decimal.Parse(txt_Peso.Text), radiobtn_SiVacuna.Checked, radiobtn_SiCastrada.Checked, dateTimePicker1.Value);

            nGrabados = objNegMascota.abmMascotas("Alta", NuevaMascota);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar la mascota en el sistema");
            }
            else
            {
                //NuevaMascota.NombreMascota = txt_Nombre.Text;
                //NuevaMascota.Sexo = cmb_Sexo.Text;
                //NuevaMascota.Peso = int.Parse(txt_Peso.Text);
                //NuevaMascota.UltimoControl = dateTimePicker1.Value;
                //NuevaMascota.Vacunada = radiobtn_SiVacuna.Checked;
                //NuevaMascota.Castrada = radiobtn_SiCastrada.Checked;

                MessageBox.Show("Se grabó con éxito la Mascota.");
                LlenarDGV();
                Limpiar();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            NuevaMasc = new Mascota(int.Parse(txt_Codigo.Text), txt_Nombre.Text, int.Parse(txt_Edad.Text), cmb_Tipo.Text, cmb_Sexo.Text, decimal.Parse(txt_Peso.Text), radiobtn_SiVacuna.Checked, radiobtn_SiCastrada.Checked, dateTimePicker1.Value);

            nResultado = objNegMascota.abmMascotas("Modificar", NuevaMasc); //invoco a la capa de negocio

            if (nResultado != -1)
            {
                MessageBox.Show("La mascota fue Modificada con éxito", "Aviso");
                Limpiar();
                LlenarDGV();

                txt_Codigo.Enabled = true;

            }
            else
                MessageBox.Show("Se produjo un error al intentar modificar la mascota", "Error");
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            #region PrgViejo
            //dgv_Mascotas.Rows.Remove(dgv_Mascotas.CurrentRow);
            #endregion

            //if (ValidarCodigoBorrar() == false)
            //{
            //    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar esta mascota de codigo " + txt_Codigo.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (resultado == DialogResult.Yes)
            //    {
            //        int nGrabados = -1;
            //        NuevaMasc = new Mascota(int.Parse(txt_Codigo.Text));
            //        nGrabados = objNegMascota.abmMascotas("Borrar", NuevaMasc);
            //        LlenarDGV();
            //    }
            //}
        }
    }
}
