using AlianzaPetrolera.Models;
using AlianzaPetrolera.RPTDataSet;
using AlianzaPetrolera.RPTDataSet.ReporteReciboTableAdapters;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace AlianzaPetrolera.Controllers.Admin
{
    public class ReportController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Report
        public ActionResult ReporteReciboCaja()
        {
            try { 
                ReportViewer reportViewer = new ReportViewer()
                {
                    ProcessingMode = ProcessingMode.Local,
                    SizeToReportContent = true,
                    Width = Unit.Percentage(100),
                    Height = Unit.Percentage(100)
                };

                ReporteRecibo.ReciboCajasDataTable data1 = new ReporteRecibo.ReciboCajasDataTable();
                ReciboCajasTableAdapter adapter = new ReciboCajasTableAdapter();
                adapter.Fill(data1);
                if (data1 != null && data1.Rows.Count > 0)
                {
                    reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Recibo1", data1.CopyToDataTable()));
                    reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"\RPTReports\ReporteRecibos.rdlc.";
                    ViewBag.ReportViewer = reportViewer;
                }
                else
                {
                    ViewBag.TextError = "No hay data valida para esta auto evaluacion";
                }
            }
            catch (Exception ex)
            {
                ViewBag.TextError = ex.Message;
            }

            return View();
        }
    }
}