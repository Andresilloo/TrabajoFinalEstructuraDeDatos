using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos_VarelaAndres
{
    class Pila
    {
        private Nodo Prim;
        public Nodo Primero
        {
            get { return Prim; }
            set { Prim = value; }
        }
        public void Agregar(Nodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = null;
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero == null)
            {
                Primero = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            Nodo aux = Primero;
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(DataGridView DgvLista)
        {
            DgvLista.Rows.Clear();
            Nodo aux = Primero;
            while (aux != null)
            {
                DgvLista.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            Nodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
    }
}

