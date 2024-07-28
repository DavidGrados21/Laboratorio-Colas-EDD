using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    internal class Cola
    {

        private Nodo vprimero;
        private Nodo vultimo;

        public Nodo primero
        {
            get { return vprimero; }
            set { vprimero = value; }
        }

        public Nodo ultimo
        {
            get { return vultimo; }
            set { vultimo = value; }
        }

        public void encolar(int x)
        {
            Nodo nuevo = new Nodo(x);

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                ultimo.sgte = nuevo;
            }
            ultimo = nuevo;
        }

        public int desencolar()
        {
            int x;
            x = primero.info;
            primero = primero.sgte;
            if (primero == null)
                ultimo = null;
            return x;
        }
        public bool esVacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
                return false;
        }

        public void mostrar(ListBox lst)
        {
            lst.Items.Clear();
            Nodo p = primero;
            while (p != null)
            {
                lst.Items.Add(p.info);
                p = p.sgte;
            }
        }
    }
}
