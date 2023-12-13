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
    public partial class frm00Principal : Form
    {
        public frm00Principal()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm01AcercaDe Ventana = new frm01AcercaDe();
            Ventana.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm02EstrucLineal_Cola Ventana = new frm02EstrucLineal_Cola();
            Ventana.ShowDialog();

        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm03EstrucLinealPila Ventana = new frm03EstrucLinealPila();
            Ventana.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstructuraLineal_ListaSimple Ventana = new EstructuraLineal_ListaSimple();
            Ventana.ShowDialog();
        }

        private void listaDoblementeLigadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm05EstrucLineal_ListaDoble Ventana = new frm05EstrucLineal_ListaDoble();
            Ventana.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm05EstrucNoLineal_ArbolBinario Ventana = new frm05EstrucNoLineal_ArbolBinario();
            Ventana.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm06EstrucNoLineal_Grafo Ventana = new frm06EstrucNoLineal_Grafo();
            Ventana.ShowDialog();
        }
    }
}
