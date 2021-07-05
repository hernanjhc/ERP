using ERP.Models;
using System;
using System.Linq;
using System.Configuration;

namespace ERP.Lib
{
    public static class Configuration
    {
        private static DateTime _currentDate;
        public static int IdUsuarioConectado;

        public static DateTime CurrentDate
        {
            get
            {
                using (var db = new VentasConexión())
                {
                    if (_currentDate == DateTime.MinValue)
                    {
                        var dQuery = db.Database.SqlQuery<DateTime>("SELECT GETDATE()");
                        _currentDate = dQuery.AsEnumerable().First();
                    }
                    return _currentDate;
                }
            }
        }

        public static short IdEmpresa
        {
            get
            {
                return 1;
            }
        }

        public static string Version
        {
            get
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                var v = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
                return v.FileVersion;
            }
        }

        public static bool ImprimePresupuestos
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["ImprimePresupuesto"]);
            }
        }

        public static bool ImprimeVentas
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["ImprimeVenta"]);
            }
        }

        public static bool VentaDescuentaStock
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["VentaDescuentaStock"]);
            }
        }

        public static bool CompraIncrementaStock
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["CompraIncrementaStock"]);
            }
        }
    }
}
