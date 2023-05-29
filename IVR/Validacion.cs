using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVR
{
    internal class Validacion
    {
        string nombre;
        int numeroOrden;
        string audioMensajeValidacoin;
        string mensajeValidacion;

        Validacion (string nombre, int numeroOrden, string mensajeValidacion, string audioMensajeValidacoin)
        {
            this.nombre = nombre;
            this.numeroOrden = numeroOrden;
            this.mensajeValidacion = mensajeValidacion;
            this.audioMensajeValidacoin = audioMensajeValidacoin;
        }
    }
}
