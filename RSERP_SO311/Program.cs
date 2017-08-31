using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Reporting.WinForms;

namespace RSERP_SO311
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            #region 缓存文件清单

            //////为了解决水晶报表第一次打印慢的问题
            //DataTable dt = new DataTable();
            //dt.Columns.Add("temp");
            //////水晶报表对象
            //if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath.ToString() + @"\zzcReport\cR96.rpt"))
            //{

            ////    string CRPath = System.Windows.Forms.Application.StartupPath.ToString() + @"\zzcReport\cR96.rpt";//拼接水晶报表模板路径
            //   ReportDocument reportdocument = new ReportDocument();
            //   // reportdocument.Load(CRPath);//加载模板
            //   reportdocument.SetDataSource(dt.DefaultView);


            //}

              //为了解决水晶报表第一次打印慢的问题
           // DataTable dt = new DataTable();
           // dt.Columns.Add("temp");
           // //水晶报表对象
           //RptFileList file = new RptFileList();
           // file.SetDataSource(dt);
            #endregion 缓存文件清单




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm311(args));
        }

        
    }
}
