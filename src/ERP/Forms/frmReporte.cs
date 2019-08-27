using ERP.Lib.AppForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ERP.Forms
{
    public partial class frmReporte : Form
    {
        public frmReporte(object reporte)
        {
            InitializeComponent();
            crystalReportViewer1.SelectionMode = CrystalDecisions.Windows.Forms.SelectionMode.None;
            crystalReportViewer1.ReportSource = reporte;
        }

        //public frmReporte(object reporte, string título) : this(reporte)
        //{
        //    this.Text = título;
        //    var rd = (ReportDocument)reporte;
        //    rd.SummaryInfo.ReportTitle = título;
        //}

        public frmReporte(object reporte,   string dirección, string razónSocial, string documento, 
                        string tipoDocumento,    string comprobante,    string número, string fecha,
                        string subtotal,    string descuento,   string total,   string validez) : this(reporte)
        {
            var rd = (ReportDocument)reporte;
            rd.DataDefinition.FormulaFields["C_Dirección"].Text = "'" + dirección + "'";
            rd.DataDefinition.FormulaFields["C_RazónSocial"].Text = "'" + razónSocial + "'";
            rd.DataDefinition.FormulaFields["C_Documento"].Text = "'" + documento + "'";
            rd.DataDefinition.FormulaFields["C_TipoDocumento"].Text = "'" + tipoDocumento + "'";
            rd.DataDefinition.FormulaFields["Comprobante"].Text = "'" + comprobante + "'";
            rd.DataDefinition.FormulaFields["Número"].Text = "'" + número + "'";
            rd.DataDefinition.FormulaFields["Fecha"].Text = "'" + fecha + "'";
            rd.DataDefinition.FormulaFields["SubTotal"].Text = "'" + subtotal + "'";
            rd.DataDefinition.FormulaFields["Descuento"].Text = "'" + descuento + "'";
            rd.DataDefinition.FormulaFields["Total"].Text = "'" + total + "'";
            rd.DataDefinition.FormulaFields["Validez"].Text = "'" + validez + "'";
        }
    }
}
