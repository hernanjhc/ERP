using ERP.Lib.AppForms;
using ERP.Models;
using ERP.Repositories;
using FileHelpers;
using System;
using System.IO;

namespace ERP.Forms.Articulos
{
    public partial class frmImportarTxt : FormBase
    {
        public frmImportarTxt()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, System.EventArgs e)
        {
            Exportar();

        }

        private static void Exportar()
        {
            var engine = new FileHelperAsyncEngine<EArticulosImport>();
            var productos = EArticulosRepository.ObtenerArticulosParaExportar();
            var destino = VerificarDestino();
            using (engine.BeginWriteFile(destino))
            {
                foreach (EArticulosImport cust in productos)
                {
                    engine.WriteNext(cust);
                }
            }
        }

        private static string VerificarDestino()
        {
            var destino = String.Format(@"C:/Temp/Productos {0:dd-MM-yyyy}.txt", DateTime.Now);
            if (!Directory.Exists("C:/Temp/"))
            {
                System.IO.Directory.CreateDirectory("C:/Temp/");
            }
            return destino;
        }
    }
}
