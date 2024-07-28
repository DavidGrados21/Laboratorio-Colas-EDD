using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class Nodo
    {
        private int vinfo;
        private Nodo vsgte;

        public int info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }

        public Nodo sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }

        public Nodo(int vinfo)
        {
            info = vinfo;
            vsgte = null;
        }

        public Nodo(int vinfo, Nodo vsgte)
        {
            info = vinfo;
            sgte = vsgte;
        }
    }
}
