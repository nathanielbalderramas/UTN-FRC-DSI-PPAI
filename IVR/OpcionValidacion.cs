using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR
{
    internal class OpcionValidacion
    {
        string descripcion;
        bool correcta;

        OpcionValidacion (string descripcion, bool correcta)
        {
            this.descripcion = descripcion;
            this.correcta = correcta;
        }

        internal bool EsCorrecta() { return correcta; }
    }
}