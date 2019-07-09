using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models
{
    public enum EstadoCliente
    {
        /// <summary>
        /// El cliente está activo.
        /// </summary>
        Activo = 1,

        /// <summary>
        /// El cliente está dado de baja.
        /// </summary>
        Baja = 2
    }
}
