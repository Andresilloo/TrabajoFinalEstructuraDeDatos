using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos_VarelaAndres
{
    public partial class frm02EstrucLineal_Cola : Form
    {
        public frm02EstrucLineal_Cola()
        {
            InitializeComponent();
        }

        Cola FilaDePersonas = new Cola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo ObjNodo = new Nodo();
            ObjNodo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
            ObjNodo.Nombre = txtNuevoNombre.Text;
            ObjNodo.Tramite = txtNuevoTramite.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvListCola);
            FilaDePersonas.Recorrer(lstCola);
            txtNuevoCodigo.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoTramite.Text = "";


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                txtElimCodigo.Text = FilaDePersonas.Primero.Codigo.ToString();
                txtElimNombre.Text = FilaDePersonas.Primero.Nombre;
                txtElimTramite.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvListCola);
                FilaDePersonas.Recorrer(lstCola);

            }
            else
            {
                txtElimCodigo.Text = "";
                txtElimNombre.Text = "";
                txtElimTramite.Text = "";
                MessageBox.Show("No hay personas en la Fila");


            }
        }

        private void ControlCajaTexto()
        {
            if (txtNuevoCodigo.Text != "" && txtNuevoNombre.Text != "" && txtNuevoTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtNuevoCodigo_TextChanged(object sender, EventArgs e)
        {
            ControlCajaTexto();
        }

        private void txtNuevoNombre_TextChanged(object sender, EventArgs e)
        {
            ControlCajaTexto();
        }

        private void txtNuevoTramite_TextChanged(object sender, EventArgs e)
        {
            ControlCajaTexto();
        }

        private void frm02EstrucLineal_Cola_Load(object sender, EventArgs e)
        {
            ControlCajaTexto();
        }
    }
}
