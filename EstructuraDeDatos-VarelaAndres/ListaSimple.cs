using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos_VarelaAndres
{
    class ListaSimple
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
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    Nodo Aux = Primero;
                    Nodo Ant = Primero;
                    while (Aux.Codigo < Nuevo.Codigo)
                    {
                        Ant = Aux;
                        Aux = Aux.Siguiente;

                        if (Aux == null)
                        {
                            break;
                        }                       
                    }
                    Nuevo.Siguiente = Aux;
                    Ant.Siguiente = Nuevo;
                }               
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                Nodo a = Primero;
                Nodo x = Primero;
                while (a.Codigo != Codigo)
                {
                    x = a;
                    a = a.Siguiente;
                }
                x.Siguiente = a.Siguiente;
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
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}
