using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos_VarelaAndres
{
    class ListaDoble
    {
        private Nodo pri;
        private Nodo ult;
        public Nodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public Nodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(Nodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;

            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        Nodo aux = Primero;
                        Nodo Ant = Primero;
                        while (aux.Codigo < Nuevo.Codigo)
                        {
                            Ant = aux;
                            aux = aux.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = aux;
                        aux.Anterior = Nuevo;
                        Nuevo.Anterior = Ant;
                    }

                }
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;

            }
            else
            {
                if (Ultimo.Codigo == Codigo)
                {
                    Ultimo = Ultimo.Anterior;
                    Ultimo.Siguiente = null;

                }
                else
                {
                    Nodo aux = Primero;
                    Nodo Ant = Primero;
                    while (aux.Codigo < Codigo)
                    {
                        Ant = aux;
                        aux = aux.Siguiente;
                    }
                    Ant.Siguiente = aux.Siguiente;
                    aux = aux.Siguiente;
                    aux.Anterior = Ant;

                }

            }
        }
        public void RecorrerL(ListBox LstListaDoble)
        {
            LstListaDoble.Items.Clear();
            Nodo aux = ult;
            while (aux != null)
            {
                LstListaDoble.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void RecorrerG(DataGridView DgvDoble)
        {
            DgvDoble.Rows.Clear();
            Nodo aux = Primero;


            while (aux != null)
            {
                DgvDoble.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerC(ComboBox cmbListaDoble)
        {
            cmbListaDoble.Items.Clear();
            Nodo aux = ult;

            while (aux != null)
            {
                cmbListaDoble.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
    }
}
