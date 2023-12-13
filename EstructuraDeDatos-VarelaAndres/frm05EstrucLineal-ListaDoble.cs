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
    public partial class frm05EstrucLineal_ListaDoble : Form
    {
        public frm05EstrucLineal_ListaDoble()
        {
            InitializeComponent();
        }
        ListaDoble FilaDePersonas = new ListaDoble();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Nodo ObjNodo = new Nodo();
            ObjNodo.Codigo = Convert.ToInt32(TxtCodigo.Text);
            ObjNodo.Nombre = TxtNombre.Text;
            ObjNodo.Tramite = TxtTramite.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.RecorrerL(LstListaDoble);
            FilaDePersonas.RecorrerG(DgvDoble);
            FilaDePersonas.RecorrerC(cmbListaDoble);
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtTramite.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {

                FilaDePersonas.Eliminar(Convert.ToInt32(cmbListaDoble.Text));
                FilaDePersonas.RecorrerG(DgvDoble);
                FilaDePersonas.RecorrerL(LstListaDoble);
                FilaDePersonas.RecorrerC(cmbListaDoble);
                cmbListaDoble.Text = "";
            }
            else
            {
                MessageBox.Show("No hay personas en la fila");
            }
        }

        private void ControlCajasDeTexto()
        {
            if (TxtCodigo.Text != "" && TxtNombre.Text != "" && TxtTramite.Text != "")
            {
                BtnAgregar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else
            {
                BtnAgregar.Enabled = false;
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            ControlCajasDeTexto();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            ControlCajasDeTexto();
        }

        private void TxtTramite_TextChanged(object sender, EventArgs e)
        {
            ControlCajasDeTexto();
        }
    }
}
