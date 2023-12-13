using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos_VarelaAndres
{
    class ArbolBinario
    {
        private Nodo nodoRaiz;
        private Nodo[] Vector = new Nodo[100];
        private Int32 i = 0;

        public Nodo NodoRaiz
        {
            get { return nodoRaiz; }
            set { nodoRaiz = value; }
        }    
        public void Agregar(Nodo nuevo)
        {
            nuevo.Izquierdo = null;
            nuevo.Derecho = null;

            if (nodoRaiz == null)
            {
                nodoRaiz = nuevo;
            }
            else
            {
                Nodo nodoMadre = nodoRaiz;
                Nodo nodoAux = nodoRaiz;

                while (nodoAux != null)
                {
                    nodoMadre = nodoAux;
                    if (nuevo.Codigo < nodoAux.Codigo)
                    {
                        nodoAux = nodoAux.Izquierdo;
                    }
                    else
                    {
                        nodoAux = nodoAux.Derecho;
                    }
                }

                if (nuevo.Codigo < nodoMadre.Codigo)
                {
                    nodoMadre.Izquierdo = nuevo;
                }
                else
                {
                    nodoMadre.Derecho = nuevo;
                }
            }
        }

        public void Eliminar(Int32 codigo) //Destruye el arbol, hay que guardarlo en un vector dinamico
        {
            i = 0;
            GrabarVectorInOrden(nodoRaiz, codigo);
            nodoRaiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(nodoRaiz);
            nodoRaiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        public Boolean Buscar(Nodo nodoMadre, Int32 codigo)
        {
            Boolean encontrado = false;
            if (nodoMadre.Codigo == codigo) encontrado = true;
            if (codigo < nodoMadre.Codigo && nodoMadre.Izquierdo != null) encontrado = Buscar(nodoMadre.Izquierdo, codigo);
            if (codigo > nodoMadre.Codigo && nodoMadre.Derecho != null) encontrado = Buscar(nodoMadre.Derecho, codigo);
            return encontrado;
        }
        private void GrabarVectorInOrden(Nodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
                Vector[i] = NodoPadre;
                i = i + 1;      
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        private void GrabarVectorInOrden(Nodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        public void Recorrer(ListBox lista, Int32 tipo)
        {
            lista.Items.Clear();

            switch (tipo)
            {
                case 1:
                    InOrdenAsc(lista, NodoRaiz);
                    break;
                case 2:
                    PreOrdenAsc(lista, NodoRaiz);
                    break;
                case 3:
                    PostOrdenAsc(lista, NodoRaiz);
                    break;
                case 4:
                    InOrdenDes(lista, NodoRaiz);
                    break;
                case 5:
                    PreOrdenDes(lista, NodoRaiz);
                    break;
                case 6:
                    PostOrdenDes(lista, NodoRaiz);
                    break;
            }
        }
        private void InOrdenAsc(ListBox lista, Nodo nodoMadre)
        {
            if (nodoMadre.Izquierdo != null) InOrdenAsc(lista, nodoMadre.Izquierdo);
            lista.Items.Add(nodoMadre.Codigo + " - " + nodoMadre.Nombre + " - " + nodoMadre.Tramite);
            if (nodoMadre.Derecho != null) InOrdenAsc(lista, nodoMadre.Derecho);
        }
        private void PreOrdenAsc(ListBox lista, Nodo nodoMadre)
        {
            lista.Items.Add(nodoMadre.Codigo + " - " + nodoMadre.Nombre + " - " + nodoMadre.Tramite);
            if (nodoMadre.Izquierdo != null) PreOrdenAsc(lista, nodoMadre.Izquierdo);
            if (nodoMadre.Derecho != null) PreOrdenAsc(lista, nodoMadre.Derecho);
        }
        private void PostOrdenAsc(ListBox lista, Nodo nodoMadre)
        {
            if (nodoMadre.Izquierdo != null) PostOrdenAsc(lista, nodoMadre.Izquierdo);
            if (nodoMadre.Derecho != null) PostOrdenAsc(lista, nodoMadre.Derecho);
            lista.Items.Add(nodoMadre.Codigo + " - " + nodoMadre.Nombre + " - " + nodoMadre.Tramite);
        }
        private void InOrdenDes(ListBox lista, Nodo nodoMadre)
        {
            if (nodoMadre.Derecho != null) InOrdenDes(lista, nodoMadre.Derecho);
            lista.Items.Add(nodoMadre.Codigo + " - " + nodoMadre.Nombre + " - " + nodoMadre.Tramite);
            if (nodoMadre.Izquierdo != null) InOrdenDes(lista, nodoMadre.Izquierdo);
        }
        private void PreOrdenDes(ListBox lista, Nodo nodoMadre)
        {
            if (nodoMadre.Derecho != null) PreOrdenDes(lista, nodoMadre.Derecho);
            if (nodoMadre.Izquierdo != null) PreOrdenDes(lista, nodoMadre.Izquierdo);
            lista.Items.Add(nodoMadre.Codigo + " - " + nodoMadre.Nombre + " - " + nodoMadre.Tramite);
        }
        private void PostOrdenDes(ListBox lista, Nodo nodoMadre)
        {
            lista.Items.Add(nodoMadre.Codigo + " - " + nodoMadre.Nombre + " - " + nodoMadre.Tramite);
            if (nodoMadre.Derecho != null) PostOrdenDes(lista, nodoMadre.Derecho);
            if (nodoMadre.Izquierdo != null) PostOrdenDes(lista, nodoMadre.Izquierdo);
        }

        public void Recorrer(ComboBox combo, Int32 tipo)
        {
            combo.Items.Clear();

            switch (tipo)
            {
                case 1:
                    InOrdenAsc(combo, NodoRaiz);
                    break;
                case 2:
                    PreOrdenAsc(combo, NodoRaiz);
                    break;
                case 3:
                    PostOrdenAsc(combo, NodoRaiz);
                    break;
                case 4:
                    InOrdenDes(combo, NodoRaiz);
                    break;
                case 5:
                    PreOrdenDes(combo, NodoRaiz);
                    break;
                case 6:
                    PostOrdenDes(combo, NodoRaiz);
                    break;
            }
        }
        private void InOrdenAsc(ComboBox combo, Nodo nodoMadre)
        {
            if (nodoMadre.Izquierdo != null) InOrdenAsc(combo, nodoMadre.Izquierdo);
            combo.Items.Add(nodoMadre.Codigo);
            if (nodoMadre.Derecho != null) InOrdenAsc(combo, nodoMadre.Derecho);
        }
        private void PreOrdenAsc(ComboBox combo, Nodo nodoMadre)
        {
            combo.Items.Add(nodoMadre.Codigo);
            if (nodoMadre.Izquierdo != null) PreOrdenAsc(combo, nodoMadre.Izquierdo);
            if (nodoMadre.Derecho != null) PreOrdenAsc(combo, nodoMadre.Derecho);
        }
        private void PostOrdenAsc(ComboBox combo, Nodo nodoMadre)
        {
            if (nodoMadre.Izquierdo != null) PostOrdenAsc(combo, nodoMadre.Izquierdo);
            if (nodoMadre.Derecho != null) PostOrdenAsc(combo, nodoMadre.Derecho);
            combo.Items.Add(nodoMadre.Codigo);
        }
        private void InOrdenDes(ComboBox combo, Nodo nodoMadre)
        {
            if (nodoMadre.Derecho != null) InOrdenDes(combo, nodoMadre.Derecho);
            combo.Items.Add(nodoMadre.Codigo);
            if (nodoMadre.Izquierdo != null) InOrdenDes(combo, nodoMadre.Izquierdo);
        }
        private void PreOrdenDes(ComboBox combo, Nodo nodoMadre)
        {
            if (nodoMadre.Derecho != null) PreOrdenDes(combo, nodoMadre.Derecho);
            if (nodoMadre.Izquierdo != null) PreOrdenDes(combo, nodoMadre.Izquierdo);
            combo.Items.Add(nodoMadre.Codigo);
        }
        private void PostOrdenDes(ComboBox combo, Nodo nodoMadre)
        {
            combo.Items.Add(nodoMadre.Codigo);
            if (nodoMadre.Derecho != null) PostOrdenDes(combo, nodoMadre.Derecho);
            if (nodoMadre.Izquierdo != null) PostOrdenDes(combo, nodoMadre.Izquierdo);
        }

        public void Recorrer(DataGridView grilla, Int32 tipo)
        {
            grilla.Rows.Clear();

            switch (tipo)
            {
                case 1:
                    InOrdenAsc(grilla, NodoRaiz);
                    break;
                case 2:
                    PreOrdenAsc(grilla, NodoRaiz);
                    break;
                case 3:
                    PostOrdenAsc(grilla, NodoRaiz);
                    break;
                case 4:
                    InOrdenDes(grilla, NodoRaiz);
                    break;
                case 5:
                    PreOrdenDes(grilla, NodoRaiz);
                    break;
                case 6:
                    PostOrdenDes(grilla, NodoRaiz);
                    break;
            }
        }
        private void InOrdenAsc(DataGridView grilla, Nodo nodoMadre)
        {
            if (nodoMadre.Izquierdo != null) InOrdenAsc(grilla, nodoMadre.Izquierdo);
            grilla.Rows.Add(nodoMadre.Codigo, nodoMadre.Nombre, nodoMadre.Tramite);
            if (nodoMadre.Derecho != null) InOrdenAsc(grilla, nodoMadre.Derecho);
        }
        private void PreOrdenAsc(DataGridView grilla, Nodo nodoMadre)
        {
            grilla.Rows.Add(nodoMadre.Codigo, nodoMadre.Nombre, nodoMadre.Tramite);
            if (nodoMadre.Izquierdo != null) PreOrdenAsc(grilla, nodoMadre.Izquierdo);
            if (nodoMadre.Derecho != null) PreOrdenAsc(grilla, nodoMadre.Derecho);
        }
        private void PostOrdenAsc(DataGridView grilla, Nodo nodoMadre)
        {
            if (nodoMadre.Izquierdo != null) PostOrdenAsc(grilla, nodoMadre.Izquierdo);
            if (nodoMadre.Derecho != null) PostOrdenAsc(grilla, nodoMadre.Derecho);
            grilla.Rows.Add(nodoMadre.Codigo, nodoMadre.Nombre, nodoMadre.Tramite);
        }
        private void InOrdenDes(DataGridView grilla, Nodo nodoMadre)
        {
            if (nodoMadre.Derecho != null) InOrdenDes(grilla, nodoMadre.Derecho);
            grilla.Rows.Add(nodoMadre.Codigo, nodoMadre.Nombre, nodoMadre.Tramite);
            if (nodoMadre.Izquierdo != null) InOrdenDes(grilla, nodoMadre.Izquierdo);
        }
        private void PreOrdenDes(DataGridView grilla, Nodo nodoMadre)
        {
            if (nodoMadre.Derecho != null) PreOrdenDes(grilla, nodoMadre.Derecho);
            if (nodoMadre.Izquierdo != null) PreOrdenDes(grilla, nodoMadre.Izquierdo);
            grilla.Rows.Add(nodoMadre.Codigo, nodoMadre.Nombre, nodoMadre.Tramite);
        }
        private void PostOrdenDes(DataGridView grilla, Nodo nodoMadre)
        {
            grilla.Rows.Add(nodoMadre.Codigo, nodoMadre.Nombre, nodoMadre.Tramite);
            if (nodoMadre.Derecho != null) PostOrdenDes(grilla, nodoMadre.Derecho);
            if (nodoMadre.Izquierdo != null) PostOrdenDes(grilla, nodoMadre.Izquierdo);
        }
    }   
}
