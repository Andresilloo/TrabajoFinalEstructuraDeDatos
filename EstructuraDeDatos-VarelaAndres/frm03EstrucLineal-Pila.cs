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
    public partial class frm03EstrucLinealPila : Form
    {
        public frm03EstrucLinealPila()
        {
            InitializeComponent();
        }

        Pila PilaDePersonas = new Pila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo ObjNodo = new Nodo();
            ObjNodo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
            ObjNodo.Nombre = txtNuevoNombre.Text;
            ObjNodo.Tramite = txtNuevoTramite.Text;
            PilaDePersonas.Agregar(ObjNodo);
            PilaDePersonas.Recorrer(dgvListPila);
            PilaDePersonas.Recorrer(lstPila);
            txtNuevoCodigo.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (PilaDePersonas.Primero != null)
            {
                txtElimCodigo.Text = PilaDePersonas.Primero.Codigo.ToString();
                txtElimNombre.Text = PilaDePersonas.Primero.Nombre;
                txtElimTramite.Text = PilaDePersonas.Primero.Tramite;
                PilaDePersonas.Eliminar();
                PilaDePersonas.Recorrer(dgvListPila);
                PilaDePersonas.Recorrer(lstPila);
            }
            else
            {
                LblElimCodigo.Text = "";
                LblElimNombre.Text = "";
                LblElimTramite.Text = "";
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
    }
}
