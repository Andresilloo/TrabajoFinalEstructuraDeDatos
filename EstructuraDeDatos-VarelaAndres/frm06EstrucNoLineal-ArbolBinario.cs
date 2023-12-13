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
    public partial class frm05EstrucNoLineal_ArbolBinario : Form
    {
        public frm05EstrucNoLineal_ArbolBinario()
        {
            InitializeComponent();
        }
        ArbolBinario objArbol = new ArbolBinario();
        Int32 tipoListado = 1;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objArbol.Agregar(objNodo);

            Listar();

            HabilitarRadioButtonsYCheckBox();
            HabilitarBotonEquilibrar();
            ReiniciarControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objArbol.Eliminar(Convert.ToInt32(dgvArbolBinario.Rows[dgvArbolBinario.CurrentCell.RowIndex].Cells[0].Value));

            Listar();

            HabilitarRadioButtonsYCheckBox();
            HabilitarBotonEquilibrar();
            dgvArbolBinario.ClearSelection(); dgvArbolBinario.CurrentCell = null;
            HabilitarBotonEliminar();
        }

        private void btnEquilbrar_Click(object sender, EventArgs e)
        {
            objArbol.Equilibrar();
            Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 codigoABuscar = Convert.ToInt32(txtCodigoABuscar.Text);
            if (objArbol.Buscar(objArbol.NodoRaiz, codigoABuscar))
            {
                foreach (DataGridViewRow fila in dgvArbolBinario.Rows)
                {
                    if (Convert.ToInt32(fila.Cells[0].Value) == codigoABuscar)
                    {
                        dgvArbolBinario.Rows[fila.Index].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el elemento buscado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvArbolBinario.ClearSelection();
            }
        }

        private void Listar()
        {
            if (objArbol.NodoRaiz != null)
            {
                if (!chkOrdenDescencente.Checked)
                {
                    objArbol.Recorrer(lstInOrden, 1); objArbol.Recorrer(lstArbolPreOrden, 2); objArbol.Recorrer(lstArbolPostOrden, 3);
                    objArbol.Recorrer(dgvArbolBinario, tipoListado);
                }
                else
                {
                    objArbol.Recorrer(lstInOrden, 4); objArbol.Recorrer(lstArbolPreOrden, 5); objArbol.Recorrer(lstArbolPostOrden, 6);
                    objArbol.Recorrer(dgvArbolBinario, tipoListado + 3);
                }

            }
            else
            {
                lstInOrden.Items.Clear(); lstArbolPreOrden.Items.Clear(); lstArbolPostOrden.Items.Clear();
                dgvArbolBinario.Rows.Clear();
            }
        }

        private void HabilitarBotonAgregar()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "") btnAgregar.Enabled = true;
            else btnAgregar.Enabled = false;
        }

        private void HabilitarBotonEliminar()
        {
            if (dgvArbolBinario.SelectedRows != null && objArbol.NodoRaiz != null) btnEliminar.Enabled = true;
            else btnEliminar.Enabled = false;
        }

        private void HabilitarBotonBuscar()
        {
            if (txtCodigoABuscar.Text != "" && objArbol.NodoRaiz != null) btnBuscar.Enabled = true;
            else btnBuscar.Enabled = false;
        }

        private void HabilitarBotonEquilibrar()
        {
            if (objArbol.NodoRaiz != null) btnEquilbrar.Enabled = true;
            else btnEquilbrar.Enabled = false;
        }

        private void HabilitarRadioButtonsYCheckBox()
        {
            if (objArbol.NodoRaiz != null)
            {
                optInOrden.Enabled = true; optPreOrden.Enabled = true; optPostOrden.Enabled = true;
                chkOrdenDescencente.Enabled = true;
            }
            else
            {
                optInOrden.Enabled = false; optPreOrden.Enabled = false; optPostOrden.Enabled = false;
                chkOrdenDescencente.Enabled = false;
            }
        }

        private void ReiniciarControles()
        {
            txtCodigo.Text = ""; txtNombre.Text = ""; txtTramite.Text = "";
            txtCodigo.Focus(); btnAgregar.Enabled = false;
            dgvArbolBinario.ClearSelection(); dgvArbolBinario.CurrentCell = null;
        }

        //EVENTOS
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonAgregar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonAgregar();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonAgregar();
        }

        private void txtCodigoABuscar_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonBuscar();
        }

        private void dgvArbolBinario_Click(object sender, EventArgs e)
        {
            HabilitarBotonEliminar();
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            tipoListado = 1;
            Listar();
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            tipoListado = 2;
            Listar();
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            tipoListado = 3;
            Listar();
        }

        private void chkOrdenDescencente_CheckedChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsDigit(pressedKey) || char.IsControl(pressedKey))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtCodigoABuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsDigit(pressedKey) || char.IsControl(pressedKey))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
