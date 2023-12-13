using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos_VarelaAndres
{
    class Nodo
    {
        private Int32 Cod;
        private String Nom;
        private String Tram;
        private Nodo Sig;
        private Nodo ant;
        private ListaSimple aristas;
        //Declaracion de propiedades
        public Int32 Codigo
        {
            get { return Cod; }
            set { Cod = value; }
        }
        public String Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public String Tramite
        {
            get { return Tram; }
            set { Tram = value; }
        }
        public Nodo Siguiente
        {
            get { return Sig; }
            set { Sig = value; }
        }
        public Nodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }
        public Nodo Izquierdo
        {
            get { return Sig; }
            set { Sig = value; }
        }
        public Nodo Derecho
        {
            get { return ant; }
            set { ant = value; }
        }
        public ListaSimple Aristas
        {
            get { return aristas; }
            set { aristas = value; }
        }
    }
}

