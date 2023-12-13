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
    public partial class EstructuraLineal_ListaSimple : Form
    {
        public EstructuraLineal_ListaSimple()
        {
            InitializeComponent();
        }

        ListaSimple ListaSimpDePersonas = new ListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo ObjNodo = new Nodo();
            ObjNodo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
            ObjNodo.Nombre = txtNuevoNombre.Text;
            ObjNodo.Tramite = txtNuevoTramite.Text;
            ListaSimpDePersonas.Agregar(ObjNodo);
            ListaSimpDePersonas.Recorrer(dgvListaSimp);
            ListaSimpDePersonas.Recorrer(lstListaSimp);
            ListaSimpDePersonas.Recorrer(cmbEliminar);

            txtNuevoCodigo.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaSimpDePersonas.Primero != null)
            {
                Nodo ObjNodo = new Nodo();
                ListaSimpDePersonas.Eliminar(Convert.ToInt32(cmbEliminar.Text));
                ListaSimpDePersonas.Recorrer(cmbEliminar);
                ListaSimpDePersonas.Recorrer(dgvListaSimp);
                ListaSimpDePersonas.Recorrer(lstListaSimp);
                cmbEliminar.Text = "";
            }
            else
            {

                MessageBox.Show("No hay personas en la Lista");
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
