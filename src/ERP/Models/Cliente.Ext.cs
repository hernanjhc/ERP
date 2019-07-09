using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models
{
    public partial class Cliente
    {
        public string LeyendaEstado
        {
            get
            {
                return "Activo";
                //switch ((EstadoCliente)Estado)
                //{
                //    case EstadoCliente.Activo:
                //        return "Activo";
                //    case EstadoCliente.Baja:
                //        return "Baja";
                //}
                //return "";
            }
        }
    }
}
